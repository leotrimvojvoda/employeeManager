using System;
using Xunit;
using Emanager01.Data;
using Emanager01.Models;
namespace Testing.DatabaseTests
{
     public class AddressCrudTest : CRUDTest
    {

        Address address = new Address();


        [Fact(Skip = "Just")]
        public void addTest()
        {

            CRUD emx = new AddressQuerry();

            address.AddressId = "VD77AD";
            address.State = "California";
            address.City = "Manchester";
            address.Street = "Braking ST";
            address.HouseNumber = 23;

            emx.add(address);

        }

        [Fact(Skip = "Just")]
        public void getTest()
        {

            var emx = new AddressQuerry();

         
            Console.WriteLine(((Address)emx.get("VD05AD")).ToString());

        }

        [Fact(Skip = "Just")]
        public void updateTest()
        {

            Address newAddress = new Address();

            newAddress.AddressId = ("XZ44AD");
            newAddress.State = "Kosovoa";
            newAddress.City = "Skenderaj";
            newAddress.Street = "Top";
            newAddress.HouseNumber = 33;


            var emx = new AddressQuerry();

            emx.update("VD77AD", newAddress);


        }

        [Fact(Skip = "Just")]
        public void deleteTest()
        {

            var emx = new AddressQuerry();

            emx.delete("VD76AD");

        }

        

    }
}
