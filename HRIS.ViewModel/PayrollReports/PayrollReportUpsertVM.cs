using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.PayrollReports
{
    public class PayrollReportUpsertVM
    {
        public long Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string PayrollGroup { get; set; }
        public decimal MonthIncome { get; set; }
    }
}
