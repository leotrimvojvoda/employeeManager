using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Emanager01.Models
{
    public partial class Contract
    {
        public string ContractId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Salary is required")]
        //[MinLength(3, ErrorMessage = "Cannot be less than 99")]
        public decimal? Salary { get; set; }

        public Contract(string contractId, DateTime startDate, DateTime endDate, decimal? salary)
        {
            ContractId = contractId;
            StartDate = startDate;
            EndDate = endDate;
            Salary = salary;
        }

        public Contract()
        {
        }

        public override string ToString()
        {
            return $"CONTRACT: {ContractId} ; {StartDate} - {EndDate} (${Salary})";
        }
    }
}
