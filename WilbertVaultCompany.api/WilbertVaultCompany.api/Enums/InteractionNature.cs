using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WilbertVaultCompany.api.Enums
{
    public enum InteractionNature
    {
        [Display(Name = "- Select -")]
        Choose,
        
        [Display(Name = "Questions on order")]
        QuestionsOnOrder,
        
        [Display(Name = "Courtesy call")]
        CourtesyCall,
        
        Complaint,
        Appointment,

        [Display(Name = "Drive by")]
        DriveBy,

        [Display(Name = "Follow up")]
        WorkOnDisplay,

        [Display(Name = "Work on display")]
        FollowUp
    }
}
