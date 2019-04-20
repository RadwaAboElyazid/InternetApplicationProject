using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetApplicationProject.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public float ProjectPrice { get; set; }
        public string ProjectComment { get; set; }
        public Status Status { get; set; }
        public int? StatusID { get; set; }
        public ApplicationUser Customer { get; set; }
        public String CustomerID { get; set; }

    }
}