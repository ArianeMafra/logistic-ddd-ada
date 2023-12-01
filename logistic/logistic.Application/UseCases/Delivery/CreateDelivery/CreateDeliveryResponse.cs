﻿public sealed record CreateDeliveryResponse
{
    public Guid Id { get; set; }
    public Address Address { get; set; }
    public Recipient Recipient { get; set; }
    public List<Product> Products { get; set; }
    public Status Status { get; set; }
    public DateTime EstimatedDeliveryTime { get; set; }
    public DateTime DeliveryDate { get; set; }
    public double Price { get; set; }

}