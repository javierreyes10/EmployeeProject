using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireSpring.View
{
    public interface IEmployeeView
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Phone { get; set; }
        string Zip { get; set; }
        DateTime HireDate { get; set; }

    }
}
