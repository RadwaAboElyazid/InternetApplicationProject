using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InternetApplicationProject.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            userIdentity.AddClaim(new Claim(type: "UserRule", value: this.UserRule.ToString()));
            userIdentity.AddClaim(new Claim(type: "FirstName", value: this.FirstName.ToString()));
            userIdentity.AddClaim(new Claim(type: "LastName", value: this.LastName.ToString()));
            userIdentity.AddClaim(new Claim(type: "UserImageUrl", value: this.UserImageUrl.ToString()));
            userIdentity.AddClaim(new Claim("Id", this.Id.ToString()));
            return userIdentity;
        }
        public string UserRule { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserImageUrl { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<ProjectRequest> ProjectRequests { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<RequestRole> RequestRoles { get; set; }
        public DbSet<Request> Requests { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}