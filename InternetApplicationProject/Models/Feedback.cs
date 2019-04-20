using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetApplicationProject.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public int Rate { get; set; }
        public ApplicationUser TeamLeader { get; set; }
        public int? TeamLeaderID { get; set; }
        public ApplicationUser JuniorDev { get; set; }
        public int? JuniorDevID { get; set; }
    }
}