var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure persistence 
builder.Services.ConfigurePersistenceApp(builder.Configuration);

// Register services related to the application
// auto mapper, mediator, fluent id
builder.Services.ConfigureApplicationApp();

// Configure CORS
builder.Services.ConfigureCorsPolicy();

var app = builder.Build();

//Create BD
BD.CreateDatabase(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
