using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.Employees
{
    public class EmployeeUpsertVM
    {
        public string EmployeeNumber { get; set; }
        public string CandidateId { get; set; }
        public string Job { get; set; }
        public DateTime? HiredDate { get; set; }
    }
}
