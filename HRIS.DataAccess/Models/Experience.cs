using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class Experience
    {
        public int Id { get; set; }
        public long EmployeeNumber { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Employee EmployeeNumberNavigation { get; set; }
    }
}
