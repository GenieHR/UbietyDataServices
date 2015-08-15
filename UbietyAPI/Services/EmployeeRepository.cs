using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UbietyAPI.Models;


namespace UbietyAPI.Services
{
    public class EmployeeRepository
    {
      
        public Employee[] getAllEmployees()
        {
            return new Employee[] {
                new Employee {FirstName = "Lakshman", EmpId = 123, Address="Danavaipeta", City="Rajahmundry", HREmpId="AC1", LastName="Pilaka" }
            };
        }
        
        public Employee[] EmployeeList()
        {

            Employee employee = new Employee();

            
            return null;

        }
    }
}