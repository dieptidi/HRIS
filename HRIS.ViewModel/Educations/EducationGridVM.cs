using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.Educations
{
    public class EducationGridVM
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string EducationLevel { get; set; }
        public string InstitutionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal LastValue { get; set; }
    }
}
