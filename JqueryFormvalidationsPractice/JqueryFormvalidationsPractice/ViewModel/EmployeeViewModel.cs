using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryFormvalidationsPractice.ViewModel
{
    public class EmployeeViewModel
    {
        

        [Required(ErrorMessage = "Employee name is required")]
       public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Salary is required")]

        public decimal Salary { get; set; }
    }

}
