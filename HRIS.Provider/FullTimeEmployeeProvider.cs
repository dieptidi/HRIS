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
                    Allowance = emp.Allowance,
                    HiredDate = Helper.FormatDate(emp.EmployeeNumberNavigation.HiredDate.Value),
                    Job = emp.EmployeeNumberNavigation.Job
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

        public bool Insert(FullTimeUpsertVM model)
        {
            using (var dbContext = new HRISContext())
            {
                try
                {
                    FullTimeEmployee employee = new FullTimeEmployee();
                    Helper.CopyProperties(model, employee);
                    dbContext.FullTimeEmployees.Add(employee);
                    return true;

                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Update(FullTimeUpsertVM model) 
        {
            try
            {
                using (var dbContext = new HRISContext())
                {
                    var selected = dbContext.FullTimeEmployees.SingleOrDefault(fte => fte.Id == model.Id);
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
                    var selected = dbContext.FullTimeEmployees.SingleOrDefault(fte => fte.Id == (int)id);
                    if (selected == null)
                    {
                        return false;
                    }

                    dbContext.FullTimeEmployees.Remove(selected);
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
