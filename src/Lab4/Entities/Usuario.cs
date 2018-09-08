
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4.Entities
{
    /// <summary>
    /// Model do usuário
    /// </summary>
    public class Usuario
    {
        [Key]
        [Required]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MinLength(10)]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Phone]
        public string Celular { get; set; }
        public DateTime DataNascimento { get; set; }
        public IList<Pedido> Pedidos { get; set; }
        
        [MaxLength(100)]
        [EmailAddress(ErrorMessage ="Deu ruim...")]
        public string Email { get; set; }

        [MaxLength(13)]
        public string CPF { get; set; }

        
    }
}