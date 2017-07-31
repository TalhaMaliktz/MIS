using MIS_DAL.Employee;
using MIS_DAL.Medical;
using MIS_DAL.Miscellaneous;
using MIS_DAL.Organization;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MIS_DAL.ContextClass
{
    public class MISContext : DbContext
    {
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

    }
}
