using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class Candidate
    {
        public Candidate()
        {
            Employees = new HashSet<Employee>();
            Interviews = new HashSet<Interview>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string IdcardNumber { get; set; }
        public string JobApply { get; set; }
        public DateTime ApplyDate { get; set; }
        public decimal SallaryRequest { get; set; }

        public virtual Test Test { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Interview> Interviews { get; set; }
    }
}
