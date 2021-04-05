using System;
using System.Linq;
using Emanager01.Models;

namespace Emanager01.Data
{
    public class AddressQuerry : CRUD
    {

        EmsDatabaseContext emx;

        Address generalAddress;

        public AddressQuerry()
        {
            emx = new EmsDatabaseContext();
            generalAddress = new Address();
        }

        public void add(object obj)
        {
            if(obj is Address)
            {
                try
                {
                    emx.Add((Address)obj);
                    emx.SaveChanges();
                }catch(Exception e)
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("ERROR ADDING ADDRESS");
            }
        }

        public object get(string id)
        {
            try
            {
                generalAddress.AddressId = id;

                var address = emx.Addresses.First(a => a.AddressId == id);

                return address;

            }catch(Exception e)
            {
                Console.WriteLine("ERROR RETURNING ADDRESS");
                Console.WriteLine(e);
            }
            
            return null;
        }

        public void update(string id, object newAddress)
        {

            if(newAddress is Address)
            {
                try
                {
                    var address = emx.Addresses.First(a => a.AddressId == id);

                    if (address != null)
                    {
                        address.State = ((Address)newAddress).State;
                        address.City = ((Address)newAddress).City;
                        address.Street = ((Address)newAddress).Street;
                        address.HouseNumber = ((Address)newAddress).HouseNumber;
                        emx.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("ADDRESS DOES NOT EXIST");
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("ERROR UPDATING ADDRESS");
                }
            }

        }

        public void delete(string id)
        {

            generalAddress.AddressId = id;

            try
            {

                var address = emx.Addresses.First(a => a.AddressId == id);


               if(address != null)
                {
                    emx.Attach(address);
                    emx.Remove(address);
                    emx.SaveChanges();
                }
                else
                {
                    Console.WriteLine("ADDRESS DOES NOT EXIST");
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("ERROR UPDATING ADDRESS");
            }

        }
    }
}
