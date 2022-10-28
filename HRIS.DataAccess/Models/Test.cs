using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class Test
    {
        public string CandidateId { get; set; }
        public string Pic { get; set; }
        public int MinutesDuration { get; set; }
        public string QuestionType { get; set; }
        public DateTime TestDate { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}
