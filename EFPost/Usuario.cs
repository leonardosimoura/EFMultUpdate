using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.SqlServer;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFPost
{
    public class Usuario
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UsuarioId { get; set; }

        public string Nome { get; set; }
    }
}
