using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AireSpring.Repository;
using Newtonsoft.Json;
using Unity.Attributes;

namespace AireSpring
{
    /// <summary>
    /// Summary description for EmployeeHandler
    /// </summary>
    public class EmployeeHandler : IHttpHandler
    {
        [Dependency]
        public IEmployeeRepository EmployeeRepository { get; set; }
        public void ProcessRequest(HttpContext context)
        {
            var employees = EmployeeRepository.GetEmployees().Select(m => new
            {
                m.Id,
                m.FirstName,
                m.LastName,
                m.Phone,
                m.Zip,
                HireDate = m.HireDate.ToString("MM/dd/yyyy")
            }).OrderBy(m=>m.HireDate);
            context.Response.ContentType = "text/json";
            context.Response.Write(JsonConvert.SerializeObject(employees));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}