using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Siav_MVC.Models.DTO
{
    public class DTO_Employee
    {
        public int IdEmployee { get; set; }
        [DisplayName("Nome")]
        [Required(ErrorMessage ="Campo Obbligatorio")]
        public String FirstName { get; set; }
        [DisplayName("Cognome")]
        [Required(ErrorMessage = "Campo Obbligatorio")]
        public String LastName { get; set; }
    }
}