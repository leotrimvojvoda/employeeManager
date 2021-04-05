using System;
using System.Collections.Generic;

#nullable disable

namespace Emanager01.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int? Phone { get; set; }
        public string ContractId { get; set; }
        public string AddressId { get; set; }

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

        }


        public override string ToString()
        {
            return $"Employee [{EmployeeId}] - {FirstName} {LastName} {DateOfBirth.ToString()} {Position} {Email} {Gender} {Phone} {ContractId} {AddressId}";
        }
    }
}
