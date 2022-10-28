using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class Interview
    {
        public string CandidateId { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Pic { get; set; }
        public int MinutesDuration { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}
