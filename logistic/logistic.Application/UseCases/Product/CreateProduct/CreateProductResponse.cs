public sealed record CreateProductResponse
{
    public Guid Id { get; set; }
    public string ProductName { get; set; }
    public double ProductPrice { get; set; }
    public int Quantity { get; set; }
}