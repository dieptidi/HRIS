using System;
using System.Collections.Generic;
using System.Text;
using HRIS.DataAccess.Models;
using HRIS.Provider.Helpers;
using HRIS.ViewModel.Tests;
using System.Linq;

namespace HRIS.Provider
{
    public class TestProvider
    {
        private static TestProvider _instance = new TestProvider();
        public static TestProvider GetProvider()
        {
            return _instance;
        }

        public List<TestGridVM> GetGrid()
        {
            using (var dbContext = new HRISContext())
            {
                var tests = dbContext.Tests.Select(ts => new TestGridVM
                {
                    CandidateId = ts.CandidateId,
                    CandidateName = $"{ts.Candidate.FirstName} {ts.Candidate.LastName}",
                    MinutesDuration = ts.MinutesDuration,
                    Pic = ts.Pic,
                    QuestionType = ts.QuestionType,
                    TestDate = Helper.FormatDate(ts.TestDate)
                }).AsEnumerable();
                return tests.ToList();
            }
        }

        public TestUpsertVM GetSingle(object id)
        {
            using (var dbContext = new HRISContext())
            {
                Test test = dbContext.Tests.SingleOrDefault(ts => ts.CandidateId == id.ToString());
                TestUpsertVM vm = new TestUpsertVM();
                Helper.CopyProperties(test, vm);
                return vm;
            }
        }

        public bool Insert(TestUpsertVM model)
        {
            try
            {
                using (var dbContext = new HRISContext())
                {
                    Test test = new Test();
                    Helper.CopyProperties(model, test);
                    dbContext.Tests.Add(test);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Update(TestUpsertVM model)
        {
            try
            {
                using (var dbContext = new HRISContext())
                {
                    var selected = dbContext.Tests.SingleOrDefault(ts => ts.CandidateId == model.CandidateId);
                    if(selected == null) { return false; }

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
                    var selected = dbContext.Tests.SingleOrDefault(ts => ts.CandidateId == id.ToString());
                    if (selected == null) { return false; }

                    dbContext.Tests.Remove(selected);
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
