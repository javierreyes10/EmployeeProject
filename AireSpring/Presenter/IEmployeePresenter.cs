using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AireSpring.Model;
using AireSpring.View;

namespace AireSpring.Presenter
{
    public interface IEmployeePresenter
    {
        IEmployeeView EmployeeView { get; set; }
        void Initialize(string id);
        void GetEmployee(int id);
        void SaveEmployee();
    }
}
