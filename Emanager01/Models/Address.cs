using System;
using System.Collections.Generic;

#nullable disable

namespace Emanager01.Models
{
    public partial class Address
    {
        public string AddressId { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int? HouseNumber { get; set; }

        public Address(string addressId, string state, string city, string street, int? houseNumber)
        {
            AddressId = addressId;
            State = state;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
        }

        public Address()
        {
            
        }

        public override string ToString()
        {
            return $"ADDRESS: {AddressId} - {State}, {City}, {Street} {HouseNumber}";
        }
    }


}
