using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class EmployeeShiftGroupDemo
    {
        public string EmployeeNumber { get; set; }
        public long ShiftGroupId { get; set; }

        public virtual Employee EmployeeNumberNavigation { get; set; }
        public virtual ShiftGroup ShiftGroup { get; set; }
    }
}
