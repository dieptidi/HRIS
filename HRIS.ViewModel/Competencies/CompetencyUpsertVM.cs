using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.Competencies
{
    public class CompetencyUpsertVM
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int SkillLevel { get; set; }
    }
}
