using System;
using System.ComponentModel.DataAnnotations;
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
