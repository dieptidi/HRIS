using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class PayrollReport
    {
        public long Id { get; set; }
        public long EmployeeNumber { get; set; }
        public string PayrollGroup { get; set; }
        public decimal MonthIncome { get; set; }

        public virtual Employee EmployeeNumberNavigation { get; set; }
    }
}
