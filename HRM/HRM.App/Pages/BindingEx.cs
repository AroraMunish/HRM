using HRM.App.Services;
using HRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.App.Pages
{
    public partial class BindingEx
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
        }

        public void btnLowerCase_Click()
        {
            Employee.FirstName = Employee.FirstName.ToLower();
            Employee.LastName = Employee.LastName.ToLower();
        }
    }
}
