using HRM.Api.Data;
using HRM.Shared;
using System.Collections.Generic;
using System.Linq;

namespace HRM.Api.Repository
{
    public class HRMRepository : IHRMRepository
    {
        private readonly HRMDBContext _hrmDBContext;

        public HRMRepository(HRMDBContext hrmDbContext)
        {
            _hrmDBContext = hrmDbContext;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _hrmDBContext.Employees;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _hrmDBContext.Employees.FirstOrDefault(c => c.EmployeeId == employeeId);
        }

        public Employee AddEmployee(Employee employee)
        {
            var addedEntity = _hrmDBContext.Employees.Add(employee);
            _hrmDBContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var foundEmployee = _hrmDBContext.Employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);

            if (foundEmployee != null)
            {
                foundEmployee.CountryId = employee.CountryId;
                foundEmployee.MaritalStatus = employee.MaritalStatus;
                foundEmployee.BirthDate = employee.BirthDate;
                foundEmployee.City = employee.City;
                foundEmployee.Email = employee.Email;
                foundEmployee.FirstName = employee.FirstName;
                foundEmployee.LastName = employee.LastName;
                foundEmployee.Gender = employee.Gender;
                foundEmployee.PhoneNumber = employee.PhoneNumber;
                foundEmployee.Smoker = employee.Smoker;
                foundEmployee.Street = employee.Street;
                foundEmployee.Zip = employee.Zip;
                foundEmployee.JobCategoryId = employee.JobCategoryId;
                foundEmployee.Comment = employee.Comment;
                foundEmployee.ExitDate = employee.ExitDate;
                foundEmployee.JoinedDate = employee.JoinedDate;

                _hrmDBContext.SaveChanges();

                return foundEmployee;
            }

            return null;
        }

        public void DeleteEmployee(int employeeId)
        {
            var foundEmployee = _hrmDBContext.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
            if (foundEmployee == null) return;

            _hrmDBContext.Employees.Remove(foundEmployee);
            _hrmDBContext.SaveChanges();
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return _hrmDBContext.Countries;
        }

        public Country GetCountryById(int countryId)
        {
            return _hrmDBContext.Countries.FirstOrDefault(c => c.CountryId == countryId);
        }

        public IEnumerable<JobCategory> GetAllJobCategories()
        {
            return _hrmDBContext.JobCategories;
        }

        public JobCategory GetJobCategoryById(int jobCategoryId)
        {
            return _hrmDBContext.JobCategories.FirstOrDefault(c => c.JobCategoryId == jobCategoryId);
        }
    }

}
