using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.FullTimeEmployees
{
    public class FullTimeUpsertVM
    {
        public long Id { get; set; }
        public string EmployeeNumber { get; set; }
        public decimal Salary { get; set; }
        public decimal Allowance { get; set; }
    }
}
