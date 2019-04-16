using Siav_MVC.Models;
using Siav_MVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Siav_MVC.Controllers
{
    [EnableCors(origins: "http://localhost:6257", headers: "*", methods: "*")]
    public class APIEmployeesController : ApiController
    {
        private IRepository _repository;
        public APIEmployeesController()
        {
            _repository = new EFRepository();
        }

        [HttpGet]
        [Route("api/allemployees", Name = "GetAllEmployees")]
        public async Task<IHttpActionResult> GetAllEmployees()
        {
            return await Task.Run(() => 
            {
                List<DTO_Employee> resultList = _repository.getAllEmployees();
                return Ok(resultList);
            });

            //List<DTO_Employee> resultList = _repository.getAllEmployees();
            //return Ok(resultList);
        }

        [HttpGet]
        [Route("api/employeebyid", Name = "GetEmployeeByID")]
        public async Task<IHttpActionResult> GetEmployeeByID([FromUri]int IDEmployee)
        {
            return await Task.Run(() =>
            {
                DTO_Employee result = _repository.getEmployeeByID(IDEmployee);
                return Ok(result);
            });

            //List<DTO_Employee> resultList = _repository.getAllEmployees();
            //return Ok(resultList);
        }

    }
}
