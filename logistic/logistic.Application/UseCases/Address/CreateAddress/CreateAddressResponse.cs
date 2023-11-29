﻿public sealed record CreateAddressResponse
{
    public Guid Id { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }
    public string Neighborhood { get; set; }
    public string ZipCode { get; set; }
    public string? AddressLine2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public Region Region { get; set; }
}