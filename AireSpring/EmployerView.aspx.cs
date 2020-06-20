using System;
using System.Globalization;
using AireSpring.Presenter;
using AireSpring.Service;
using AireSpring.View;
using static System.Int16;

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
            get => Parse(txtEmployeeId.Text);
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

        public string Phone
        {
            get => txtPhone.Text;
            set => txtPhone.Text = value;
        }

        public string Zip
        {
            get => txtZip.Text;
            set => txtZip.Text = value;
        }

        public DateTime HireDate
        {
            get => DateTime.Parse(txtHireDate.Text);
            set => txtHireDate.Text = value.ToString(CultureInfo.InvariantCulture);
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