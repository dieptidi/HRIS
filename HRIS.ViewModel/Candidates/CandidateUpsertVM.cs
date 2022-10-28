using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.Candidates
{
    public class CandidateUpsertVM
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string IdcardNumber { get; set; }
        public string JobApply { get; set; }
        public DateTime ApplyDate { get; set; }
        public decimal SallaryRequest { get; set; }
    }
}
