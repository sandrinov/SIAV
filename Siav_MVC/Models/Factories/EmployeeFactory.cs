using Siav_MVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Siav_MVC.Models.Factories
{
    public class EmployeeFactory
    {
        public DTO_Employee CreateDto(Siav_MVC.Models.EF.Employee entity)
        {
            return new DTO_Employee()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                IdEmployee = entity.EmployeeID
            };
        }
        public Siav_MVC.Models.EF.Employee CreateEntity(DTO_Employee dto)
        {
            return new Siav_MVC.Models.EF.Employee()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
            };
        }
    }
}