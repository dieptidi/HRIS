using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.Interviews
{
    public class InterviewGridVM
    {
        public long Id { get; set; }
        public string CandidateName { get; set; }
        public string InterviewDate { get; set; }
        public string Pic { get; set; }
        public int MinutesDuration { get; set; }
    }
}
