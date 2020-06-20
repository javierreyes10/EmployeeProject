using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AireSpring.Presenter;
using AireSpring.Service;
using AireSpring.View;

namespace AireSpring
{
    public partial class EmployerView : System.Web.UI.Page, IEmployeeView
    {
        private IEmployeeRepository _employeeRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            _employeeRepository = new EmployeeRepository();

        }

        public int Id
        {
            get => Int16.Parse(txtEmployeeId.Text);
            set => txtEmployeeId.Text = value.ToString();
        }
        public string FirstName
        {
            get => txtFirstName.Text;
            set => txtFirstName.Text = value;
        }
        public string LastName
        {
            get => txtLastName.Text;
            set => txtLastName.Text = value;
        }

        public string Search
        {
            get => txtSearch.Text;
            set => txtSearch.Text = value;
        }

        protected void SaveEmployee(object sender, EventArgs e)
        {
            var employeePresenter = new EmployeePresenter(_employeeRepository, this);
            employeePresenter.SaveEmployee();
        }

        protected void SearchEmployee(object sender, EventArgs e)
        {
            var employeePresenter = new EmployeePresenter(_employeeRepository, this);
            employeePresenter.GetEmployee();
        }
    }
}