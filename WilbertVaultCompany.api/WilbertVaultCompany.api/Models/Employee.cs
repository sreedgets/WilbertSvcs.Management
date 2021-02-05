using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        
        [Display(Name = "Can Do Follow Ups")]
        public bool CanDoFollowUps { get; set; }
        public string Title { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string County { get; set; }
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone1 { get; set; }

        [Display(Name = "Phone Type")]
        public string PhoneType1 { get; set; }
        public string Email { get; set; }
        [Display(Name = "Employee Active")]
        public string Active { get; set; }        
        public byte[] PhotoImage { get; set; }

        public IEnumerable<AnswerVm> Answers { set; get; }
        public int SelectedAnswer { set; get; }

       
        /********************************************************************/
        [NotMapped]
        public List<Plant> Plants { get; set; }

        /**********************************************************************/
        public int PlantId { get; set; }
        public virtual Plant PlantEmployee { get; set; }
    }
    public class AnswerVm
    {
        public int Id { set; get; }
        public string Answer { set; get; }
    }

}
