using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class FullTimeEmployee
    {
        public long Id { get; set; }
        public string EmployeeNumber { get; set; }
        public decimal Salary { get; set; }
        public decimal Allowance { get; set; }

        public virtual Employee EmployeeNumberNavigation { get; set; }
    }
}
