using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EFPost
{
    public class EFSolucaoTest
    {       
        [Fact]
        public void SolucaoSalvarMultiplasVezes()
        {
            var usuario = new Usuario()
            {
                UsuarioId = Guid.NewGuid(),
                Nome = "Leonardo"
            };

            using (var context = new SolucaoContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }

            using (var context = new SolucaoContext())
            {
                for (int i = 0; i < 10; i++)
                {
                    var usuarioTest = new Usuario
                    {
                        UsuarioId = usuario.UsuarioId,
                        Nome = "alterado"
                    };

                    context.Usuarios.Attach(usuarioTest);
                    context.Entry(usuarioTest).State = EntityState.Modified;
                    context.SaveChanges();
                }
                Assert.Equal(context.Usuarios.FirstOrDefault().Nome, "alterado");
                Assert.Equal(context.Usuarios.FirstOrDefault().UsuarioId, usuario.UsuarioId);
            }
        }
    }
}