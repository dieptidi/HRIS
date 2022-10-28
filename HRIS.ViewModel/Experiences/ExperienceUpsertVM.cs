using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.Experiences
{
    public class ExperienceUpsertVM
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
