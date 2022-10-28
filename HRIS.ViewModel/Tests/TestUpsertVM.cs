using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.Tests
{
    public class TestUpsertVM
    {
        public long Id { get; set; }
        public long CandidateId { get; set; }
        public string Pic { get; set; }
        public int MinutesDuration { get; set; }
        public string QuestionType { get; set; }
        public DateTime TestDate { get; set; }
    }
}
