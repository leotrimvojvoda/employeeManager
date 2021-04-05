using System;
using System.Collections.Generic;

#nullable disable

namespace Emanager01.Models
{
    public partial class Remark
    {
        public int RemarksId { get; set; }
        public DateTime? RemarkDate { get; set; }
        public string Remark1 { get; set; }
        public int EmployeeId { get; set; }

        public Remark(int remarksId, DateTime? remarkDate, string remark1, int employeeId)
        {
            RemarksId = remarksId;
            RemarkDate = remarkDate;
            Remark1 = remark1;
            EmployeeId = employeeId;
        }

        public Remark()
        {
        }

        public override string ToString()
        {
            return $"REMARK: {RemarksId} ; {RemarkDate} {Remark1} {EmployeeId} ";
        }
    }
}
