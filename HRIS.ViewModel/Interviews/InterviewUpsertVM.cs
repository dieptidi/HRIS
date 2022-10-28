using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.Interviews
{
    public class InterviewUpsertVM
    {
        public long Id { get; set; }
        public long CandidateId { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Pic { get; set; }
        public int MinutesDuration { get; set; }
    }
}
