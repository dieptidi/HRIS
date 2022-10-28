using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.PartTimeEmployees
{
    public class PartTimeEmployeeUpsertVM
    {
        public long Id { get; set; }
        public string EmployeeNumber { get; set; }
        public decimal Wages { get; set; }
        public int WorkDays { get; set; }
    }
}
