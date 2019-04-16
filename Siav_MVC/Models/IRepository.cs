using Siav_MVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Siav_MVC.Models
{
    public interface IRepository
    {
        List<DTO_Employee> getAllEmployees();
        DTO_Employee getEmployeeByID(int EmployeeID);
        bool NewEmployee(DTO_Employee employee);
    }
}