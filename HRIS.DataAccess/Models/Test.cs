using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class Test
    {
        public long Id { get; set; }
        public long CandidateId { get; set; }
        public string Pic { get; set; }
        public int MinutesDuration { get; set; }
        public string QuestionType { get; set; }
        public DateTime TestDate { get; set; }

        public virtual Candidate IdNavigation { get; set; }
    }
}
