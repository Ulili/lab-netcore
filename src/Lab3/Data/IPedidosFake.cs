using System.Collections.Generic;
using Lab3.Models;

namespace Lab3.Data
{
    public interface IPedidosFake
    {
        IList<Pedido> Pedidos(int quantidade);
    }
}