using HRIS.ViewModel.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.FullTimeEmployees
{
    public class FullTimeEmployeeGridVM : EmployeeGridVM
    {
        public long Id { get; set; }
        //public string FullName { get; set; }
        //public string Gender { get; set; }
        //public string BirthDate { get; set; }
        //public string BirthPlace { get; set; }
        //public string IdcardNumber { get; set; }
        //public string EmployeeNumber { get; set; }
        public decimal Salary { get; set; }
        public decimal Allowance { get; set; }
    }
}
