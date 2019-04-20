using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetApplicationProject.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public DateTime Time { get; set; }

        public Project Project { get; set; }
        public int? ProjectID { get; set; }
        public ApplicationUser ProjectManger { get; set; }
        public int? ProjectMangerID { get; set; }
    }
}