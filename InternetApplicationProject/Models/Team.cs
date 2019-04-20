using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetApplicationProject.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public ApplicationUser User { get; set; }
        public String UserID { get; set; }
    }
}