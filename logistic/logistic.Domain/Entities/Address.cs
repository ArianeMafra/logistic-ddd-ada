﻿public class Address : BaseEntity
{
    public string Street { get; set; }
    public int Number { get; set; }
    public string Neighborhood { get; set; }
    public string ZipCode { get; set; }
    public string? AddressLine2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public Region Region { get; set; }

}
