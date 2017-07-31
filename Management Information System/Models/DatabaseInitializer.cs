using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Management_Information_System.Models
{
    public class DatabaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {

        }
    }
}