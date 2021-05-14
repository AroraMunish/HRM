using HRM.Shared;
using System.Collections.Generic;

namespace HRM.Api.Repository
{
    public interface IHRMRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);

        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);

        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);


    }
}
