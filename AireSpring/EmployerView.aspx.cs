﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Web.Script.Services;
using System.Web.Services;
using AireSpring.Dto;
using AireSpring.Model;
using AireSpring.Presenter;
using AireSpring.Service;
using AireSpring.View;
using Unity.Attributes;
using static System.Int16;

namespace AireSpring
{
    public partial class EmployerView : System.Web.UI.Page, IEmployeeView
    {
        private readonly IEmployeePresenter _employeePresenter;
        public EmployerView(IEmployeePresenter employeePresenter)
        {
            _employeePresenter = employeePresenter;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            _employeePresenter.EmployeeView = this;
        }

        #region ControlProperties
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

        #endregion


        protected void SaveEmployee(object sender, EventArgs e)
        {
            _employeePresenter.SaveEmployee();
        }

        protected void SearchEmployee(object sender, EventArgs e)
        {

            _employeePresenter.GetEmployee();
        }


    }
}