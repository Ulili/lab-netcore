
using System;
using System.Collections.Generic;

namespace Lab3.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public DateTime DataNascimento { get; set; }
        public IList<Pedido> Pedidos { get; set; }
    }
}