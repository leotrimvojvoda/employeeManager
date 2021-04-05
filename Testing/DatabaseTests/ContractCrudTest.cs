using System;
using Emanager01.Data;
using Emanager01.Models;
using Xunit;
namespace Testing.DatabaseTests
{
    public class ContractCrudTest : CRUDTest
    {
        public ContractCrudTest()
        {
        }

        [Fact(Skip = "Just")]
        public void addTest()
        {
            Contract contract = new Contract();

            contract.ContractId = "TC091CT";
            contract.StartDate = new DateTime(2021, 10, 31);
            contract.EndDate = new DateTime(2022, 12, 31);
            contract.Salary = 850;

            var emx = new ContractQuerry();

            emx.add(contract);
           
        }

        [Fact(Skip = "Just")]
        public void deleteTest()
        {
            var emx = new ContractQuerry();

            emx.delete("XZ09CT");
        }

        [Fact(Skip = "Just")]
        public void getTest()
        {
            var emx = new ContractQuerry();

            var cnt = emx.get("AN02CT");
        }

        [Fact (Skip ="Just")]
        public void updateTest()
        {
            var emx = new ContractQuerry();

            Contract newContract = new Contract();

            newContract.ContractId = "XZ09CT";
            newContract.StartDate = new DateTime(2022, 01, 01);
            newContract.EndDate = new DateTime(2025, 01, 01);
            newContract.Salary = 4700;

            emx.update("AN02CT", newContract);
        }
    }
}
