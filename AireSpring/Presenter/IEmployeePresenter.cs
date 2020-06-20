using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AireSpring.Model;

namespace AireSpring.Presenter
{
    interface IEmployeePresenter
    {
        void Initialize();

        void GetEmployee();
        void SaveEmployee();
    }
}
