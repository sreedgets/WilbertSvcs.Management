using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Interaction
    {
        public int InteractionId { get; set; }
        public DateTime Date { get; set; }
        public int Nature { get; set; }
        public string Notes { get; set; }
        public DateTime FollowUpDate { get; set; }
        public int Reason { get; set; }
        public bool Completed { get; set; }
        public string Outcome { get; set; }
        public int? FuneralHomeId { get; set; }
    }
}
