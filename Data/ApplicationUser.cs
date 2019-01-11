using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Burza.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string NameAndSurname { get; set; }
            
        public byte[] ProfilePicture { get; set; }

    }
}
