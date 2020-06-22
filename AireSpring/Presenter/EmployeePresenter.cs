using System;
using AireSpring.Model;
using AireSpring.Repository;
using AireSpring.View;
using AutoMapper;

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
            Mapper.Map(employee, EmployeeView);
        }


        public bool SaveEmployee()
        {
            var employee = new Employee();

            Mapper.Map(EmployeeView, employee);

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