using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace AppraisalSystem.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "First Name"), Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name"), Required]
        public string LastName { get; set; }
        public string County { get; set; }
        public int PFNumber { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName) { }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<County> County_Dbset { get; set; }
        public DbSet<SubCounty> SubCounty_Dbset { get; set; }
        public DbSet<personaldetails> personaldetailsDbset { get; set; }
        public DbSet<apraiseeandsupervisorcomments> apraiseeandsupervisorcommentsDbset { get; set; }
        public DbSet<performancetargets> performancetargetsDbset { get; set; }
        public DbSet<performancesummary> performancesummaryDbset { get; set; }
        public DbSet<supervisorcomments> supervisorcommentsDbset { get; set; }
        public DbSet<traininganddevelopmentplan> traininganddevelopmentplanDbset { get; set; }
        public DbSet<valuesandcompetency> valuesandcompetencyDbset { get; set; }

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