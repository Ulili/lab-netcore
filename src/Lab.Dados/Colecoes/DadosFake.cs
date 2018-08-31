using System;
using System.Collections.Generic;
using Lab.Dados.Models;

namespace Lab.Dados.Colecoes
{
    public class DadosFake
    {

        public IList<Usuario> Usuarios(int quantidade)
        {
            var resultado = new List<Usuario>();
            Random rnd = new Random();

            if (quantidade > 0)
            {
                for (int i = 0; i < quantidade; i++)
                {
                    resultado.Add(new Usuario{
                        Nome = $"Usuário dos Santos {quantidade}",
                        Id = quantidade,
                        Pedidos = Pedidos(rnd.Next(1, 20)) //Gerar inteiros aleatorios de 1 a 20
                    });
                }
            }

            return resultado;
        }

        /// <summary>
        /// Gera dados Fake de Pedidos
        /// </summary>
        /// <param name="quantidade"></param>
        /// <returns></returns>
        public IList<Pedido> Pedidos(int quantidade)
        {
            var resultado = new List<Pedido>();
            Random rnd = new Random();

            if (quantidade > 0)
            {
                for (int i = 0; i < quantidade; i++)
                {
                    resultado.Add(new Pedido{
                        DataCompra = DateTimeOffset.UtcNow,
                        Id = Guid.NewGuid(),
                        Produtos = Produtos(rnd.Next(1, 11)) //Gerar inteiros aleatorios de 1 a 11
                    });
                }
            }

            return resultado;
        }

        /// <summary>
        /// Gera dados fake dos produtos dado uma quantidade
        /// limite
        /// </summary>
        /// <param name="quantidade">quantidade limite</param>
        /// <returns>lista dos produtos</returns>
        public IList<Produto> Produtos(int quantidade)
        {
            var resultado = new List<Produto>();
            if (quantidade > 0)
            {
                for (int i = 0; i < quantidade; i++)
                {
                    resultado.Add(new Produto
                    {
                        Descricao = $"Descricao_{quantidade}",
                        Id = Guid.NewGuid(),
                        SKU = $"SKU#ABC{quantidade}",
                        Preco = (100 / quantidade) * 3
                    });
                }
            }

            return resultado;
        }
    }
}