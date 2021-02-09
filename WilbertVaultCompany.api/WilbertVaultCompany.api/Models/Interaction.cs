using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Interaction
    {
        public int InteractionId { get; set; }
        public DateTime Date { get; set; }
        public string Nature { get; set; }
        public string Notes { get; set; }
        public DateTime FollowUpDate { get; set; }
        public string Reason { get; set; }

        public string Outcome { get; set; }
        public int? FuneralHomeId { get; set; }
        public string fhName { get; set; }
        /*********************************************************************/
        public IEnumerable<CompletedVm> Answers { set; get; }

        
        public int SelectedAnswer { set; get; }
        public string Completed { get; set; }
    }
    public class CompletedVm
    {
        public int Id { set; get; }
        public string Answer { set; get; }
    }
}
