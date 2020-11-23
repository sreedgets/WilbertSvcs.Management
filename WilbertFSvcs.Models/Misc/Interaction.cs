using System;
using WilbertFSvcs.Models.Enums;

namespace WilbertFSvcs.Models.Misc
{
    public class Interaction
    {
        public int InteractionId { get; set; }
        public DateTime Date { get; set; }
        public InteractionNature Nature { get; set; }
        public string Notes { get; set; }
        public DateTime FollowUpDate { get; set; }
        public FollowUpReason Reason { get; set; }
        public Boolean Completed { get; set; }
        public string Outcome { get; set; }
    }
}
