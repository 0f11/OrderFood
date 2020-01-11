using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        [Display(Name ="Feedback")]
        public string FeedbackComment { get; set; }
    }
}    