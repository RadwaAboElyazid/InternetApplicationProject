using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetApplicationProject.Models
{
    public class ProjectRequest
    {
        public int ProjectRequestId { get; set; }
        public string ProjectRequestName { get; set; }
        public ApplicationUser ProjectManger { get; set; }
        public int? ProjectMangerID { get; set; }
        public Status Status { get; set; }
        public int? StatusID { get; set; }
        public Project Project { get; set; }
        public int? ProjectID { get; set; }

    }
}