using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HRIS.ViewModel.Candidates;
using HRIS.DataAccess.Models;
using HRIS.Provider.Helpers;

namespace HRIS.Provider
{
    public class CandidateProvider
    {
        public List<CandidateGridVM> GetGrid()
        {
            using (var dbContext = new HRISContext())
            {
                var candidates = dbContext.Candidates.Select(can => new CandidateGridVM
                {
                    Id = can.Id,
                    CandidateName = Helper.FormatName(can.FirstName, can.LastName, can.Gender),
                    Gender = can.Gender,
                    BirthDate = Helper.FormatDate(can.BirthDate),
                    BirthPlace = can.BirthPlace,
                    IdcardNumber = can.IdcardNumber,
                    JobApply = can.JobApply,
                    ApplyDate = Helper.FormatDate(can.ApplyDate),
                    SallaryRequest = Helper.FormatRupiah(can.SallaryRequest)
                }).AsEnumerable();
                return candidates.ToList();
            }
        }

        public CandidateUpsertVM GetSingle(object id)
        {
            using (var dbContext = new HRISContext())
            {
                var candidate = dbContext.Candidates.SingleOrDefault(can => can.Id.Equals(id.ToString()));
                CandidateUpsertVM vm = new CandidateUpsertVM();
                Helper.CopyProperties(candidate, vm);
                return vm;
            }
        }

        public bool Insert(CandidateUpsertVM model)
        {
            using (var dbContext = new HRISContext())
            {
                Candidate candidate = new Candidate();
                model.Id = GenerateId(model.JobApply, model.ApplyDate);
                Helper.CopyProperties(model, candidate);
                dbContext.Candidates.Add(candidate);
                return true;
            }
        }

        public bool Update(CandidateUpsertVM model)
        {
            try
            {
                using (var dbContext = new HRISContext())
                {
                    var selected = dbContext.Candidates.SingleOrDefault(can => can.Id == model.Id);
                    if (selected == null)
                    {
                        return false;
                    }
                    Helper.CopyProperties(model, selected);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(object id)
        {
            try
            {
                using (var dbContext = new HRISContext())
                {
                    var selected = dbContext.Candidates.SingleOrDefault(can => can.Id == id.ToString());
                    if (selected == null)
                    {
                        return false;
                    }

                    dbContext.Candidates.Remove(selected);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }



        private string GenerateId(string jobApply, DateTime applyDate)
        {
            string jobCode = jobApply.Substring(0, 1).ToUpper();
            string applyDateCode = applyDate.ToString("yyMMdd");
            string firstCode = $"{jobCode}{applyDateCode}";
            var getData = GetGrid().Where(can => can.Id.Contains(firstCode)).ToList().Select(can => can.Id);
            if (getData.Count() == 0)
            {
                return $"{firstCode}001";
            }
            else
            {
                var lastOrderCode = getData.Last().ToString().Substring(7);
                var newOrderCode = Convert.ToInt32(lastOrderCode);
                return $"{firstCode}{newOrderCode.ToString("000")}";
            }
        }
    }
}
