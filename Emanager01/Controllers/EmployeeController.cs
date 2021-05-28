using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emanager01.Models;
using Emanager01.Data;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Emanager01.Controllers
{
    public class EmployeeController : Controller
    {

        public string extractNumbers(String str)
        {

            string numbersOnly = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    numbersOnly += str[i];
            }

            return numbersOnly;

        }

        // GET: /<controller>/
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Employee()
        {

            EmployeeQuerry querry = new EmployeeQuerry();

            return View(querry.getAllEmployees());
        }


        public IActionResult AddressView(Employee employee)
        {
            return View(employee);
        }

        public IActionResult ContractView(Employee employee)
        {
            return View(employee);
        }

        public IActionResult ContractStats()
        {
            return View();
        }


        public IActionResult LocationStats()
        {
            return View();
        }

        public IActionResult GenderStats()
        {
            return View();
        }

        public IActionResult ReamrksView()
        {
            return View();
        }

        public IActionResult  AddEmployee()
        {
            return View(new Employee());
        }


        public IActionResult DepartamentView(string departaments)
        {

            Console.WriteLine(departaments + " DEP");

            EmployeeQuerry querry = new EmployeeQuerry();

            List<Employee> employees = new List<Employee>();


            foreach(Employee e in querry.getAllEmployees())
            {
                if (e.Position.Equals(departaments))
                    employees.Add(e);
            }


            return View(employees);
        }

      
        public IActionResult EditEmployee(Employee employee)
        {

            return View("AddEmployee", employee);
        }

       
        public IActionResult Search(string searchdata)
        {

            Console.WriteLine(".\n.\n.\n"+searchdata);

            EmployeeQuerry querry = new EmployeeQuerry();

            if (searchdata!=null)
            {

                List<Employee> employees = querry.getAllEmployees()
                    .FindAll(e => e.FirstName.Equals(searchdata, StringComparison.InvariantCultureIgnoreCase)
                    || e.LastName.Equals(searchdata, StringComparison.InvariantCultureIgnoreCase)
                    || (e.FirstName + " " + e.LastName).Equals(searchdata, StringComparison.InvariantCultureIgnoreCase)
                    );

                return View("Employee", employees);
            }
            else
            {
                return View("Employee", querry.getAllEmployees());
            }
        }
        
        

        [HttpPost]
        public IActionResult SaveEmployee(Employee employee,String departaments, string dateOfBirth)
        {

            employee.Position = departaments;

            string[] s = dateOfBirth.Split("-");

            employee.DateOfBirth = new DateTime(Convert.ToInt32(s[0]), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]));


            employee.AddressId = "NA";
            employee.ContractId = "NA";


            if (ModelState.IsValid)
            {

                EmployeeQuerry employeeQuerry = new EmployeeQuerry();

                employeeQuerry.add(employee);


                EmployeeQuerry querry = new EmployeeQuerry();

                return View("Employee", querry.getAllEmployees());

            }
            else
            {

                Console.WriteLine("INVALID");
                return View("AddEmployee", employee);

            }

        }

        public IActionResult UpdateEmployee(Employee employee, String departaments, string dateOfBirth)
        {

            employee.Position = departaments;

            string[] s = dateOfBirth.Split("-");

            employee.DateOfBirth = new DateTime(Convert.ToInt32(s[0]), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]));

            if (ModelState.IsValid)
            {

                EmployeeQuerry querry = new EmployeeQuerry();

                querry.update(employee.EmployeeId.ToString(), employee);

                return View("Employee", querry.getAllEmployees());

            }
            else
            {
                return View("AddEmployee", employee);
            }
        }


        [HttpPost]
        public IActionResult SaveAddress(Address address)
        {
       
            string addressId = address.AddressId;

            string id = extractNumbers(addressId);

            Console.WriteLine("EMPLOYEE ID: " + id);


            if (ModelState.IsValid)
            {

                //Format address correctly FL00AD
                address.AddressId = addressId + "AD";

                //Add address to the database
                AddressQuerry addressQuerry = new AddressQuerry();

                addressQuerry.add(address);

                //Add address id to the user
                EmployeeQuerry employeeQuerry = new EmployeeQuerry();

                Employee employee = (Employee)employeeQuerry.get(id);

                employee.AddressId = addressId + "AD";

                employeeQuerry.update(id, employee);

                EmployeeQuerry querry = new EmployeeQuerry();

                return View("Employee", querry.getAllEmployees());
            }
            else
            {
                EmployeeQuerry employeeQuerry = new EmployeeQuerry();

                Employee employee = (Employee)employeeQuerry.get(id);

                return View("AddressView", employee);
            }

        }

        public IActionResult UpdateAddress(Address address)
        {
            //Shared between both conditions
            EmployeeQuerry employeeQuerry = new EmployeeQuerry();

            if (ModelState.IsValid)
            {
                AddressQuerry addressQuerry = new AddressQuerry();

                addressQuerry.update(address.AddressId, address);


                return View("Employee", employeeQuerry.getAllEmployees());
            }
            else
            {

                string id = extractNumbers(address.AddressId);

                Employee employee = new Employee();

                employee = (Employee)employeeQuerry.get(id);
                
                return View("AddressView", employee);
            }
 
            
        }

        public IActionResult SaveContract(Contract contract,string start,string end,string id, string initials) 
        {

            //End - Start != -1

            //Shared object
            ContractQuerry contractQuerry = new ContractQuerry();

            if (ModelState.IsValid)
            {

                String contractIdBuilder = initials + id + "CT";

                contract.ContractId = contractIdBuilder;

                /*The start and end date of the contract are recieved as string parameters
                 formated yyy-MM-dd. I used the '-' to split the string and save each value in an array position.
                 [0] Year, [1] Month, [2] Day. This is done because the DateTime Object only accepts numeric values as parameters.
                 */

                string[] s = start.Split("-");

                string[] e = end.Split("-");

                contract.StartDate = new DateTime(Convert.ToInt32(s[0]), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]));

                contract.EndDate = new DateTime(Convert.ToInt32(e[0]), Convert.ToInt32(e[1]), Convert.ToInt32(e[2]));

                //Salary is already set.

                contractQuerry.add(contract);


                /*Update employees contract reference to the new  contract*/

                EmployeeQuerry employeeQuerry = new EmployeeQuerry();

                Employee employee = (Employee)employeeQuerry.get(id);

                employee.ContractId = contractIdBuilder;

                employeeQuerry.update(id, employee);

                /*-------------------------RETURN TO THE LIST VIEW-------------------------*/
                EmployeeQuerry querry = new EmployeeQuerry();

                return View("Employee", querry.getAllEmployees());

            }
            else
            {


                EmployeeQuerry employeeQuerry = new EmployeeQuerry();

                Employee employee = (Employee)employeeQuerry.get(id);

                Console.WriteLine(employee.ToString());

                return View("ContractView", employee);

            }

           
        }

        public IActionResult UpdateContract(Contract contract)
        {

            ContractQuerry contractQuerry = new ContractQuerry();

            contractQuerry.update(contract.ContractId, contract);

            /*--------------------------------------------------*/
            EmployeeQuerry querry = new EmployeeQuerry();

            return View("Employee", querry.getAllEmployees());
        }


        public IActionResult DeleteEmployee(Employee employee)
        {

            EmployeeQuerry querry = new EmployeeQuerry();

            querry.delete(employee.EmployeeId.ToString());

            return View("Employee", querry.getAllEmployees());
        }



    }
}