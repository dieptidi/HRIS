using System;
using System.Collections.Generic;
using System.Text;
using HRIS.DataAccess.Models;
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
                var test = dbContext.Tests.FirstOrDefault(ts => ts.Id == Convert.ToInt64(id));
                return test;
            }
        }

        public bool Insert(Test model)
        {
            using (var dbContext = new HRISContext())
            {
                try
                {
                    dbContext.Add(model);
                    dbContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool Update(Test model)
        {
            throw new NotImplementedException();
        }
        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
