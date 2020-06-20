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
        private readonly IEmployeeView _employeView;

        public EmployeePresenter(IEmployeeRepository employeeRepository, IEmployeeView employeeView)
        {
             _employeeRepository = employeeRepository;
             _employeView = employeeView;
        }
        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void GetEmployee()
        {
            var search = Int16.Parse(_employeView.Search);
            var employee = _employeeRepository.GetEmployeeById(search);
            _employeView.Id = employee.Id;
            _employeView.FirstName = employee.FirstName;
            _employeView.LastName = employee.LastName;
            _employeView.Zip = employee.Zip;
            _employeView.Phone = employee.Phone;
            _employeView.HireDate = employee.HireDate;
        }


        public void SaveEmployee()
        {
            var employee = new Employee {FirstName = _employeView.FirstName, LastName = _employeView.LastName};
            _employeeRepository.SaveEmployee(employee);
        }
    }
}