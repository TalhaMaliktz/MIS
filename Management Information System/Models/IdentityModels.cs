using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;
using MIS_DAL.Employee;
using MIS_DAL.Medical;
using MIS_DAL.Miscellaneous;
using MIS_DAL.Organization;
using MIS_DAL.Location;

namespace Management_Information_System.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        //public MISContext() : base("MISContext")
        //{
        //}
        public DbSet<EmployeeDAL> Employees { get; set; }
        public DbSet<AdditionalChargeDAL> AdditionalCharge { get; set; }
        public DbSet<EmployeeBankDAL> EmployeeBank { get; set; }
        public DbSet<EmployeeEducationDAL> EmployeesEducation { get; set; }
        public DbSet<EmployeeExperienceDAL> EmployeeExperience { get; set; }
        public DbSet<EmployeeFamilyMembersDAL> EmployeesFamilyMember { get; set; }
        public DbSet<EmployeeLanguageDAL> EmployeeLanguage { get; set; }
        public DbSet<DisabilityDAL> Disability { get; set; }
        public DbSet<AddressDAL> Address { get; set; }
        public DbSet<ContactDAL> Contact { get; set; }
        public DbSet<DocumentsDAL> Documents { get; set; }
        public DbSet<AppointmentDAL> Appointment { get; set; }
        public DbSet<DepartmentDAL> Department { get; set; }
        public DbSet<PostDAL> Post { get; set; }
        public DbSet<PostingTenureDAL> PostingTenure { get; set; }
        public DbSet<PostUnderDepartmentDAL> PostUnderDepartment { get; set; }
        public DbSet<QuotaDAL> Quota { get; set; }
        public DbSet<StationDAL> Station { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}