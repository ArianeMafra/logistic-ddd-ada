using MediatR;
public sealed record CreateProductRequest(
    string ProductName, 
    double ProductPrice, 
    int Quantity) : IRequest<CreateProductResponse>;
