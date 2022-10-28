using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Competencies = new HashSet<Competency>();
            Educations = new HashSet<Education>();
            EmployeeShiftGroupDemos = new HashSet<EmployeeShiftGroupDemo>();
            Experiences = new HashSet<Experience>();
            FullTimeEmployees = new HashSet<FullTimeEmployee>();
            PartTimeEmployees = new HashSet<PartTimeEmployee>();
            PayrollReports = new HashSet<PayrollReport>();
        }

        public string EmployeeNumber { get; set; }
        public string CandidateId { get; set; }
        public string Job { get; set; }
        public DateTime? HiredDate { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual ICollection<Competency> Competencies { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<EmployeeShiftGroupDemo> EmployeeShiftGroupDemos { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<FullTimeEmployee> FullTimeEmployees { get; set; }
        public virtual ICollection<PartTimeEmployee> PartTimeEmployees { get; set; }
        public virtual ICollection<PayrollReport> PayrollReports { get; set; }
    }
}
