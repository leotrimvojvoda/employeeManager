using System;
using System.Collections.Generic;
using System.Linq;
using Emanager01.Models;

namespace Emanager01.Data
{
    public class EmployeeQuerry : CRUD
    {

        private EmsDatabaseContext emx;

        private Employee generalEmployee;
        

        public EmployeeQuerry()
        {

            emx = new EmsDatabaseContext();

            generalEmployee = new Employee();
        }


        public void add(object obj)
        {
            if (obj is Employee && obj != null)
            {
                try
                {
                    emx.Add((Employee)obj);
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
                Console.WriteLine("ERROR ADDING EMPLOYEE");
            }
        }

        public object get(string id)
        {
            try
            {

                var emp = emx.Employees.First(e => e.EmployeeId == Convert.ToInt32(id));

                return emp;

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR GETTING EMPLOYEE");
                Console.WriteLine(e);
            }

            return null;
        }

        public List<Employee> getAllEmployees()
        {
            try
            {

            return emx.Employees.ToList();

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR GETTING ALL EMPLOYEES");
                Console.WriteLine(e);
            }

            return null;
        }

        public void update(string id, object newEmployee)
        {

            if(newEmployee is Employee)
            {
                try
                {

                    var employee = emx.Employees.First(e => e.EmployeeId == Convert.ToInt32(id));


                    if(employee != null)
                    {
                        employee.FirstName = ((Employee)newEmployee).FirstName;
                        employee.LastName = ((Employee)newEmployee).LastName;
                        employee.DateOfBirth = ((Employee)newEmployee).DateOfBirth;
                        employee.Position = ((Employee)newEmployee).Position;
                        employee.Email = ((Employee)newEmployee).Email;
                        employee.Gender = ((Employee)newEmployee).Gender;
                        employee.Phone = ((Employee)newEmployee).Phone;
                        employee.ContractId = ((Employee)newEmployee).ContractId;
                        employee.AddressId = ((Employee)newEmployee).AddressId;

                        emx.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("EMPLOYEE DOES NOT EXIST");
                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("ERROR UPDATING USER");
                }
            }

        }

        public void delete(string id)
        {
            try
            {
                generalEmployee.EmployeeId = Convert.ToInt32(id);

                emx.Employees.Attach(generalEmployee);
                emx.Employees.Remove(generalEmployee);

                emx.SaveChanges();

            }catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("ERROR DELETING EMPLOYEE");
            }
        }
    }
}
