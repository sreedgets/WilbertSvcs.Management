using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WilbertSvcs.Management.Models
{
    public class Login
    {

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
       

    }
}
