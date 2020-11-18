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
        public string NickName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Spouse { get; set; }
        public Boolean ShowPrices { get; set; }
        public string Interests { get; set; }
        
        public Byte[] Photo { get; set; }

    }
}
