using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.PayrollReports
{
    public class PayrollReportGridVM
    {
        public long Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string FullName { get; set; }
        public string IdcardNumber { get; set; }
        public string Job { get; set; }
        public string HiredDate { get; set; }
        public string PayrollGroup { get; set; }
        public decimal MonthIncome { get; set; }
    }
}
