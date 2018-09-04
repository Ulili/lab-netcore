using System;
using System.Collections.Generic;
using Lab3.Models;

namespace Lab3.Data
{
    internal class PedidosFake : IPedidosFake
    {
        /// <summary>
        /// Gera dados Fake de Pedidos
        /// </summary>
        /// <param name="quantidade"></param>
        /// <returns></returns>
        public IList<Pedido> Pedidos(int quantidade)
        {
            var resultado = new List<Pedido>();
            Random rnd = new Random();
            var produtos = new ProdutosFake();

            if (quantidade > 0)
            {
                for (int i = 0; i < quantidade; i++)
                {
                    resultado.Add(new Pedido{
                        DataCompra = DateTimeOffset.UtcNow,
                        Id = Guid.NewGuid(),
                        Produtos = produtos.Produtos(rnd.Next(1, 11)) //Gerar inteiros aleatorios de 1 a 11
                    });
                }
            }

            return resultado;
        }
    }
}