using System;
using System.Collections.Generic;

namespace Lab3.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public IList<Produto> Produtos { get; set; }
        public DateTimeOffset DataCompra { get; set; }

    }
}