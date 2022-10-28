using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class Competency
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int SkillLevel { get; set; }

        public virtual Employee EmployeeNumberNavigation { get; set; }
    }
}
