using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MIS_DAL.ContextClass
{
    public class MISInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MISContext>
    {
        protected override void Seed( context)
        {
        }
    }
}
