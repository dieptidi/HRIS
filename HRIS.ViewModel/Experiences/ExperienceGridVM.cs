using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.Experiences
{
    public class ExperienceGridVM
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
