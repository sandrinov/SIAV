using Siav_MVC.Models.DTO;
using Siav_MVC.Models.EF;
using Siav_MVC.Models.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Siav_MVC.Models
{
    public class EFRepository : IRepository
    {
        NorthwindEntities _ctx;
        EmployeeFactory factory;
        public EFRepository()
        {
            _ctx = new NorthwindEntities();
            factory = new EmployeeFactory();
        }
        public List<DTO_Employee> getAllEmployees()
        {
            List<DTO_Employee> resultList = new List<DTO_Employee>();
            var reslst = _ctx.Employees.ToList();
            foreach (var emp in reslst)
            {
                resultList.Add(factory.CreateDto(emp));
            }
            return resultList;
        }
        public DTO_Employee getEmployeeByID(int EmployeeID)
        {
            var emp = _ctx.Employees.Where(e => e.EmployeeID == EmployeeID).FirstOrDefault();
            return factory.CreateDto(emp);
        }
        public bool NewEmployee(DTO_Employee employee)
        {
            bool result = true;
            Siav_MVC.Models.EF.Employee ef_employee = factory.CreateEntity(employee);
            try
            {
                _ctx.Employees.Add(ef_employee);
                _ctx.SaveChanges();
            }
            catch (Exception)
            {

                result = false;
            }
            return result;
        }
    }
}