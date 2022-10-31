using System;
using System.Collections.Generic;
using System.Text;
using HRIS.DataAccess.Models;
using HRIS.Provider.Helpers;
using HRIS.ViewModel.Interviews;
using System.Linq;

namespace HRIS.Provider
{
    public class InterviewProvider
    {
        public List<InterviewGridVM> GetGrid()
        {
            using (var dbContext = new HRISContext())
            {
                var interviews = dbContext.Interviews.Select(inr => new InterviewGridVM
                {
                    CandidateName = $"{inr.Candidate.FirstName} {inr.Candidate.LastName}",
                    InterviewDate = Helper.FormatDate(inr.InterviewDate),
                    CandidateId = inr.CandidateId,
                    MinutesDuration = inr.MinutesDuration,
                    Pic = inr.Pic
                }).AsEnumerable();
                return interviews.ToList();
            }
        }

        public InterviewUpsertVM GetSingle(object id)
        {
            using (var dbContext = new HRISContext())
            {
                var interview = dbContext.Interviews.SingleOrDefault(itr => itr.CandidateId == id.ToString());
                InterviewUpsertVM vm = new InterviewUpsertVM();
                Helper.CopyProperties(interview, vm);
                return vm;
            }
        }

        public bool Insert(InterviewUpsertVM model)
        {
            try
            {
                using (var dbContext = new HRISContext())
                {
                    Interview interview = new Interview();
                    Helper.CopyProperties(model, interview);
                    dbContext.Interviews.Add(interview);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Update(InterviewUpsertVM model)
        {
            try
            {
                using (var dbContext = new HRISContext())
                {
                    var selected = dbContext.Interviews.SingleOrDefault(itr => itr.CandidateId == model.CandidateId);
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
                    var selected = dbContext.Interviews.SingleOrDefault(itr => itr.CandidateId == id.ToString());
                    if (selected == null)
                    {
                        return false;
                    }

                    dbContext.Interviews.Remove(selected);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
