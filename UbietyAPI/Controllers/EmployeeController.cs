using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UbietyAPI.Models;
using UbietyAPI.Services;


namespace UbietyAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        private EmployeeRepository employeeRepository;

        public EmployeeController()
        {
            this.employeeRepository = new EmployeeRepository();
        }

        public Employee[] Get()
        {
            return employeeRepository.getAllEmployees();

        }

        
    }
}
