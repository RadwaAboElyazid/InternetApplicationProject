using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetApplicationProject.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public ApplicationUser User{ get; set; }
        public int? UserId { get; set; }
        public Status Status { get; set; }
        public int? StatusID { get; set; }
        public Project Project { get; set; }
        public int? ProjectID { get; set; }
        public RequestRole RequestRole { get; set; }
        public int? RequestRoleID { get; set; }

    }
}
