using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class Education
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string EducationLevel { get; set; }
        public string InstitutionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal LastValue { get; set; }

        public virtual Employee EmployeeNumberNavigation { get; set; }
    }
}
