using System;
using System.Collections.Generic;

#nullable disable

namespace Emanager01.Models
{
    public partial class Manager
    {
        public int ManagerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public int? Phone { get; set; }

        public Manager(int managerId, string firstName, string lastName, DateTime? dateOfBirth, string email, string password, string gender, int? phone)
        {
            ManagerId = managerId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            Password = password;
            Gender = gender;
            Phone = phone;
        }

        public Manager()
        {
        }

        public override string ToString()
        {
            return $"MANAGER: {ManagerId} ; {FirstName} {LastName} {DateOfBirth} {Email} {Password} {Gender} {Phone}";
        }
    }
}
