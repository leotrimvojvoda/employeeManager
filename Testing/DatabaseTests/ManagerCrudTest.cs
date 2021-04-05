using System;
using Xunit;
using Emanager01.Data;
using Emanager01.Models;
namespace Testing.DatabaseTests
{
    public class ManagerCrudTest : CRUDTest
    {
        public ManagerCrudTest()
        {
        }

        [Fact(Skip = "Just")]
        public void addTest()
        {
            var emx = new ManagerQuerry();

            Manager man = new Manager();

            man.ManagerId = 12345;
            man.FirstName = "Gramos";
            man.LastName = "Bile";
            man.DateOfBirth = new DateTime(1990, 12, 12);
            man.Email = "gramos@manager.com";
            man.Password = "password";
            man.Gender = "M";
            man.Phone = 043843123;

            emx.add(man);

        }

        [Fact (Skip = "Just")]
        public void deleteTest()
        {
            var emx = new ManagerQuerry();

            emx.delete("0");
        }

        [Fact(Skip = "Just")]
        public void getTest()
        {
            var emx = new ManagerQuerry();

            Manager manager = (Manager)emx.get("34212");

            Console.WriteLine(manager.ToString());
        }

        [Fact(Skip = "Just")]
        public void updateTest()
        {
            var emx = new ManagerQuerry();

            Manager man = new Manager();

            man.FirstName = "Updated";
            man.LastName = "User";
            man.DateOfBirth = new DateTime(1990, 12, 12);
            man.Email = "updated@manager.com";
            man.Password = "password";
            man.Gender = "M";
            man.Phone = 043843123;

            emx.update("34212",man);
        }
    }
}
