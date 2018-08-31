using System.Collections.Generic;

namespace Lab1.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public IList<Pedido> Pedidos { get; set; }
    }
}