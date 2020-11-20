using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WilbertSvcs.Management.Models
{
    public class Users
    {
        [Key]
        public int FuneralHomeContactId { get; set; }
        public int FuneralHomeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        public string Spouse { get; set; }
        public Boolean ShowPrices { get; set; }
        public string Interests { get; set; }
        
        public Byte[] Photo { get; set; }

    }
}
