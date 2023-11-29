using MediatR;
public sealed record CreateAddressRequest(
    string Street, int Number, string Neighborhood,string ZipCode, string AddressLine2, 
    string City, string State, string Country, Region Region) 
    : IRequest<CreateAddressResponse>;