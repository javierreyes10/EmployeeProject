using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AireSpring.Model;
using AireSpring.Repository;
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


        public void Initialize(string id)
        {
            if (string.IsNullOrEmpty(id) || id == "0")
            {
                EmployeeView.Id = 0;
                return;
            }

            var searchId = Int32.Parse(id); 
            GetEmployee(searchId);
        }

        public void GetEmployee(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            EmployeeView.Id = employee.Id;
            EmployeeView.FirstName = employee.FirstName;
            EmployeeView.LastName = employee.LastName;
            EmployeeView.Zip = employee.Zip;
            EmployeeView.Phone = employee.Phone;
            EmployeeView.HireDate = employee.HireDate;
        }


        public bool SaveEmployee()
        {
            var employee = new Employee {
                Id = EmployeeView.Id,
                FirstName = EmployeeView.FirstName, 
                LastName = EmployeeView.LastName,
                Phone = EmployeeView.Phone,
                Zip = EmployeeView.Zip,
                HireDate = EmployeeView.HireDate
            };

            bool isSuccess;
            if (EmployeeView.Id == 0)
            {
                isSuccess = _employeeRepository.AddEmployee(employee);
            }
            else
            {
                isSuccess = _employeeRepository.UpdateEmployee(employee);
                
            }

            if (!isSuccess)
                EmployeeView.ErrorMessage = "There was an error. Please try again later";

            return isSuccess;
        }
    }
}