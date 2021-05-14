using HRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRM.App.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeDetails(int employeeId);
        Task<Employee> AddEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(int employeeId);

        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);

        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);

    }
}
