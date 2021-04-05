using System;
using System.Linq;
using Emanager01.Models;
using Emanager01.Data;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Testing.DatabaseTests
{
   
    public class EmployeeCrudTest : CRUDTest
    {

       Employee employee = new Employee("Abdullah","Selmani", new DateTime(2010, 12, 31),
            "Instructor","anik2009@gmail.com","M",049215737,"AS01CT","AS01AD");



        [Fact(Skip = "Just")]
        public void addTest()
        {
            var emx = new EmployeeQuerry();

            emx.add(employee);
        }

        [Fact(Skip = "Just")]
        public void deleteTest()
        {
            var emx = new EmployeeQuerry();

            emx.delete("15");
        }


        [Fact(Skip = "Just")]
        public void getTest()
        {
            var emx = new EmployeeQuerry();

            Employee em = (Employee)emx.get("14");

            Console.WriteLine("SINGLE: "+em.ToString());
        }

        [Fact(Skip = "Just")]
        public void getAllTest()
        {
            var emx = new EmployeeQuerry();


            foreach(var e in emx.getAllEmployees())
            {
                Console.WriteLine(e.ToString());
            }
        }

        [Fact(Skip = "Just")]
        public void updateTest()
        {
            Employee newEmployee = new Employee("Updated", "Emp", new DateTime(2010, 12, 31),
            "Instructor", "anik2009@gmail.com", "M", 049215737, "AS01CT", "AS01AD");

            var emx = new EmployeeQuerry();

            emx.update("14", newEmployee);

        }


    }
}