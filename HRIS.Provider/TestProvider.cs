using System;
using System.Collections.Generic;
using System.Text;
using HRIS.DataAccess.Models;
using HRIS.Provider.Helpers;
using System.Linq;

namespace HRIS.Provider
{
    public class TestProvider : IProvider<Test>
    {
        private static TestProvider _instance = new TestProvider();
        public static TestProvider GetProvider()
        {
            return _instance;
        }

        public List<Test> GetAll()
        {
            using (var dbContext = new HRISContext())
            {
                var tests = dbContext.Tests.AsEnumerable();
                return tests.ToList();
            }
        }

        public Test GetSingle(object id)
        {
            using (var dbContext = new HRISContext())
            {
                var test = dbContext.Tests.SingleOrDefault(ts => ts.Id == Convert.ToInt64(id));
                return test;
            }
        }

        public bool Insert(Test model)
        {
            try
            {
                using (var dbContext = new HRISContext())
                {
                    dbContext.Add(model);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Test model)
        {
            try
            {
                using (var dbContext = new HRISContext())
                {
                    var selected = dbContext.Tests.SingleOrDefault(ts => ts.Id == model.Id);
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
                    var selected = dbContext.Tests.SingleOrDefault(ts => ts.Id == Convert.ToInt64(id));
                    if (selected == null) { return false; }


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
