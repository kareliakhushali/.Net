using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryFormvalidationsPractice.Models
{
    
        public class Person
        {
            [Required(ErrorMessage = "Name is required")]
            public string Name { get; set; }

            [EmailAddress(ErrorMessage = "Invalid email address")]
            public string Email { get; set; }

            [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]
            public int Age { get; set; }
        }

    
}
