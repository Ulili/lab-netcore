
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    /// <summary>
    /// Model do usuário
    /// </summary>
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Nome { get; set; }

        [Phone]
        public string Celular { get; set; }
        public DateTime DataNascimento { get; set; }
        public IList<Pedido> Pedidos { get; set; }

        [EmailAddress(ErrorMessage ="Deu ruim...")]
        public string Email { get; set; }
    }
}