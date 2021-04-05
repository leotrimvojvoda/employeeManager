using System;
using Emanager01.Models;
using Emanager01.Data;
using System.Linq;
namespace Emanager01.Data
{
    public class ContractQuerry : CRUD
    {

        EmsDatabaseContext emx;

        Contract generalContract;

        public ContractQuerry()
        {

            emx = new EmsDatabaseContext();

            generalContract = new Contract();

        }

        public void add(object obj)
        {
            if (obj is Contract)
            {
                try
                {
                    emx.Add((Contract)obj);
                    emx.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("ERROR ADDING CONTRACT");
            }
        }

        public object get(string id)
        {
            try
            {
                generalContract.ContractId = id;

                var contract = emx.Contracts.First(c => c.ContractId == id);

                return contract;

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR GETTING CONTRACT");
                Console.WriteLine(e);
            }

            return null;
        }

        public void update(string id, object newContract)
        {

            if (newContract is Contract)
            {
                try
                {
                    var contract = emx.Contracts.First(c => c.ContractId == id);

                    if (contract != null)
                    {
                        contract.StartDate = ((Contract)newContract).StartDate;
                        contract.EndDate = ((Contract)newContract).EndDate;
                        contract.Salary = ((Contract)newContract).Salary;
                        emx.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("CONTRACT DOES NOT EXIST");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("ERROR UPDATING CONTRACT");
                }
            }

        }

        public void delete(string id)
        {

            generalContract.ContractId = id;

            try
            {

                var contract = emx.Contracts.First(c => c.ContractId == id);



                if (contract != null)
                {
                    emx.Attach(contract);
                    emx.Remove(contract);
                    emx.SaveChanges();
                }
                else
                {
                    Console.WriteLine("CONTRACT DOES NOT EXIST");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("ERROR UPDATING CONTRACT");
            }

        }
    }
}