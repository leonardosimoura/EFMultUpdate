using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPost
{
    public class SolucaoContext : DbContext
    {
        public SolucaoContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFPost;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer<SolucaoContext>(new DropCreateDatabaseAlways<SolucaoContext>());
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public override int SaveChanges()
        {
            var retorno = base.SaveChanges();

            foreach (var item in ChangeTracker.Entries())
            {
                item.State = EntityState.Detached;
            }

            return retorno;
        }
    }
}
