using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.PartTimeEmployees
{
    public class PartTimeEmployeeGridVM
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string IdcardNumber { get; set; }
        public string EmployeeNumber { get; set; }
        public decimal Wages { get; set; }
        public int WorkDays { get; set; }    }
}
