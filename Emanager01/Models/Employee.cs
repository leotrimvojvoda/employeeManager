using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Emanager01.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="First Name is required")]
        [MinLength(3, ErrorMessage = "Name cannot be less than 3 characters")]
        [MaxLength(15, ErrorMessage = "Name cannot be more than 15 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [MinLength(3, ErrorMessage = "Last name cannot be less than 3 characters")]
        [MaxLength(15, ErrorMessage = "Last name cannot be more than 15 characters")]
        public string LastName { get; set; }
       
        public DateTime DateOfBirth { get; set; }
       
        public string Position { get; set; }
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Must me of email address format")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }
        [Required (ErrorMessage ="Phone number is required")]
        public int? Phone { get; set; }
        public string ContractId { get; set; }
        public string AddressId { get; set; }
        public List<String> departaments = new List<String>();

        public Employee(string FirstName, string LastName, DateTime DateOfBirth, string Position, string Email, string Gender, int Phone, String ContractId, string AddressId)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Position = Position;
            this.Email = Email;
            this.Gender = Gender;
            this.Phone = Phone;
            this.ContractId = ContractId;
            this.AddressId = AddressId;

        }

        public Employee()
        {
            departaments.Add("Accounting and Finance");
            departaments.Add("Human Resource Management");
            departaments.Add("Marketing");
            departaments.Add("IT");
            departaments.Add("Research and Development");
            departaments.Add("Production");
            departaments.Add("Training");

        }


        public override string ToString()
        {


            return $"Employee [{EmployeeId}] - {FirstName} {LastName} {DateOfBirth.ToString()} {Position} {Email} {Gender} {Phone} {ContractId} {AddressId}";
        }
    }
}
