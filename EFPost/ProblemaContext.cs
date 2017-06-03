using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPost
{
    public class ProblemaContext : DbContext
    {
        public ProblemaContext():base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFPost;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer<ProblemaContext>(new DropCreateDatabaseAlways<ProblemaContext>());
        }

        public DbSet<Usuario> Usuarios { get; set; }
        
    }
}
