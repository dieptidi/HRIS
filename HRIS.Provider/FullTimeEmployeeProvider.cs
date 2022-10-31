using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HRIS.ViewModel.FullTimeEmployees;
using HRIS.DataAccess.Models;
using HRIS.Provider.Helpers;

namespace HRIS.Provider
{
    public class FullTimeEmployeeProvider
    {
        private static FullTimeEmployeeProvider _instance = new FullTimeEmployeeProvider();
        public static FullTimeEmployeeProvider GetProvider() { return _instance; }

        public List<FullTimeEmployeeGridVM> GetGrid()
        {
            using (var dbContext = new HRISContext())
            {
                var fullEmployees = dbContext.FullTimeEmployees.Select(emp => new FullTimeEmployeeGridVM
                {
                    Id = emp.Id,
                    FullName = Helper.FormatName(emp.EmployeeNumberNavigation.Candidate.FirstName, emp.EmployeeNumberNavigation.Candidate.LastName, emp.EmployeeNumberNavigation.Candidate.Gender),
                    Gender = emp.EmployeeNumberNavigation.Candidate.Gender,
                    BirthDate = Helper.FormatDate(emp.EmployeeNumberNavigation.Candidate.BirthDate),
                    BirthPlace = emp.EmployeeNumberNavigation.Candidate.BirthPlace,
                    IdcardNumber = emp.EmployeeNumberNavigation.Candidate.IdcardNumber,
                    EmployeeNumber = emp.EmployeeNumber,
                    Salary = emp.Salary,
                    Allowance = emp.Allowance
                }).AsEnumerable();
                return fullEmployees.ToList();
            }
        }

        public FullTimeUpsertVM GetSingle(object id) 
        {
            using (var dbContext = new HRISContext())
            {
                var employee = dbContext.FullTimeEmployees.SingleOrDefault(ft => ft.Id == (int)id);
                FullTimeUpsertVM vm = new FullTimeUpsertVM();
                Helper.CopyProperties(employee, vm);
                return vm;
            }
        }


    }
}
