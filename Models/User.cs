using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pinball.Models
{
    public class User
    {
        [Required][StringLength(30, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required][StringLength(30, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required][MaxLength(30)][MinLength(5)]
        public string UserPassword { get; set; }

        [Required]
        public int PhoneNumber { get; set; }
    }
}
