using System;
using System.Collections.Generic;
using System.Text;
using HRIS.DataAccess.Models;
using HRIS.Provider.Helpers;
using HRIS.ViewModel.Employees;
using System.Linq;

namespace HRIS.Provider
{
    public  class EmployeeProvider
    {
        public List<EmployeeGridVM> GetGrid()
        {
            using (var dbContext = new HRISContext())
            {
                var employees = dbContext.Employees.Select(emp => new EmployeeGridVM
                {
                    EmployeeNumber = emp.EmployeeNumber,
                    FullName = $"{emp.Candidate.FirstName} {emp.Candidate.LastName}",
                    BirthDate = Helper.FormatDate(emp.Candidate.BirthDate),
                    BirthPlace = emp.Candidate.BirthPlace,
                    Gender = emp.Candidate.Gender,
                    HiredDate = Helper.FormatDate(emp.HiredDate.Value),
                    IdcardNumber = emp.Candidate.IdcardNumber,
                    Job = emp.Job,
                    CandidateId = emp.CandidateId,
                }).AsEnumerable();
                return employees.ToList();
            }
        }

        public EmployeeUpsertVM GetSingle(object id)
        {
            using (var dbContext = new HRISContext())
            {
                var employee = dbContext.Employees.SingleOrDefault(itr => itr.CandidateId == id.ToString());
                EmployeeUpsertVM vm = new EmployeeUpsertVM();
                Helper.CopyProperties(employee, vm);
                return vm;
            }
        }

        public bool Insert(EmployeeUpsertVM model)
        {
            try
            {
                using (var dbContext = new HRISContext())
                {
                    Employee employee = new Employee();
                    Helper.CopyProperties(model, employee);
                    dbContext.Employees.Add(employee);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Update(EmployeeUpsertVM model)
        {
            try
            {
                using (var dbContext = new HRISContext())
                {
                    var selected = dbContext.Employees.SingleOrDefault(itr => itr.CandidateId == model.CandidateId);
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
                    var selected = dbContext.Employees.SingleOrDefault(itr => itr.CandidateId == id.ToString());
                    if (selected == null)
                    {
                        return false;
                    }

                    dbContext.Employees.Remove(selected);
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