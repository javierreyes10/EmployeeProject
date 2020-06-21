using System;
using System.Collections.Generic;
using System.Web;
using AireSpring.Service;
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
            var employees = EmployeeRepository.GetEmployees();
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