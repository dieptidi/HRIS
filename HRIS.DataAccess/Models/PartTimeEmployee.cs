using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class PartTimeEmployee
    {
        public long Id { get; set; }
        public string EmployeeNumber { get; set; }
        public decimal Wages { get; set; }
        public int WorkDays { get; set; }

        public virtual Employee EmployeeNumberNavigation { get; set; }
    }
}
