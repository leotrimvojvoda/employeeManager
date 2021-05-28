using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Emanager01.Models
{
    public partial class Address
    {
        public string AddressId { get; set; }
        [Required(ErrorMessage = "State is required")]
        [MinLength(3, ErrorMessage = "State must contain at least 3 characters")]
        public string State { get; set; }
        [Required(ErrorMessage = "City is required")]
        [MinLength(3, ErrorMessage = "City must contain at least 3 characters")]
        public string City { get; set; }
        [Required(ErrorMessage = "Street is required")]
        [MinLength(3, ErrorMessage = "Street must contain at least 3 characters")]
        public string Street { get; set; }
        [Required(ErrorMessage = "House Number is required")]
        //[RegularExpression("[^0-9]", ErrorMessage = "House Number must be numeric")]
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
