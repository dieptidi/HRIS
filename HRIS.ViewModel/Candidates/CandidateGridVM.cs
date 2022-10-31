using HRIS.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.Candidates
{
    public class CandidateGridVM
    {
        public string Id { get; set; }
        public string CandidateName { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string IdcardNumber { get; set; }
        public string JobApply { get; set; }
        public string ApplyDate { get; set; }
        public string SallaryRequest { get; set; }
    }
}
