using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AireSpring.Model;
using AireSpring.Service;
using AireSpring.View;

namespace AireSpring.Presenter
{
    public class EmployeePresenter : IEmployeePresenter
    {
        private readonly IEmployeeRepository _employeeRepository;
        public IEmployeeView EmployeeView { get; set; }

        public EmployeePresenter(IEmployeeRepository employeeRepository)
        {
             _employeeRepository = employeeRepository;
        }


        public void GetEmployee()
        {
            var search = Int16.Parse(EmployeeView.Search);
            var employee = _employeeRepository.GetEmployeeById(search);
            EmployeeView.Id = employee.Id;
            EmployeeView.FirstName = employee.FirstName;
            EmployeeView.LastName = employee.LastName;
            EmployeeView.Zip = employee.Zip;
            EmployeeView.Phone = employee.Phone;
            EmployeeView.HireDate = employee.HireDate;
        }


        public void SaveEmployee()
        {
            var employee = new Employee {FirstName = EmployeeView.FirstName, 
                LastName = EmployeeView.LastName,
                Phone = EmployeeView.Phone,
                Zip = EmployeeView.Zip,
                HireDate = EmployeeView.HireDate
            };

            _employeeRepository.SaveEmployee(employee);
        }
    }
}