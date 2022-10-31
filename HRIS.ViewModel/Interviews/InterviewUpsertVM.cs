using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.Interviews
{
    public class InterviewUpsertVM
    {
        public string CandidateId { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Pic { get; set; }
        public int MinutesDuration { get; set; }
    }
}
