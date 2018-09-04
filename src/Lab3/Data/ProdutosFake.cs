using System;
using System.Collections.Generic;
using Lab3.Models;

namespace Lab3.Data
{
    internal class ProdutosFake : IProdutosFake
    {
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