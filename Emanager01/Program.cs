using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Emanager01.Models;

namespace Emanager01
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /*var emx = new EmsDatabaseContext();

            var employees = emx.Employees.ToList();

            var addressess = emx.Addresses.ToList();


            Employee em4 = new Employee();
           
            em4.FirstName = "Luan";
            em4.LastName = "Asllan";
            em4.Position = "Chef";
            em4.Email = "em232@gmail.com";
            em4.ContractId = 1;
            em4.AddressId = 2;


            emx.Add(em4);
            emx.SaveChanges();

            Console.WriteLine("NUMBER: "+emx.Employees.Count());

            foreach (var c in employees)
            {
                Console.WriteLine($"ID {c.EmployeeId}-- name: {c.FirstName}\n");
                
            }

            foreach (var a in addressess)
            {
                Console.WriteLine($"ADDRESS: {a.AddressId}, {a.State}, {a.City}, {a.Street} {a.HouseNumber}");
            }

            //emx.Remove(em4);
            //emx.SaveChanges();

            */

            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
