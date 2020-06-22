using System;
using System.Globalization;
using AireSpring.Presenter;
using AireSpring.View;

namespace AireSpring
{
    public partial class EmployeeView : System.Web.UI.Page, IEmployeeView
    {
        private readonly IEmployeePresenter _employeePresenter;
        public EmployeeView(IEmployeePresenter employeePresenter)
        {
            _employeePresenter = employeePresenter;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _employeePresenter.EmployeeView = this;
                var employeeId = Request.QueryString["employeeID"];
                _employeePresenter.Initialize(employeeId);
            }

        }

        #region ControlProperties
        public int Id
        {
            get => string.IsNullOrEmpty(txtEmployeeId.Text) ? 0 : Int32.Parse(txtEmployeeId.Text);
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
            get => (string.IsNullOrEmpty(txtHireDate.Text))? DateTime.MinValue : DateTime.Parse(txtHireDate.Text); 
            set => txtHireDate.Text = value.ToString(CultureInfo.InvariantCulture);
        }

        public string ErrorMessage
        {
            get => lblErrorMessage.Text;
            set => lblErrorMessage.Text = value;
        }

        #endregion


        protected void SaveEmployee(object sender, EventArgs e)
        {
            _employeePresenter.EmployeeView = this;

            if(_employeePresenter.SaveEmployee())
                Response.Redirect("Index.aspx");
        }

    }
}