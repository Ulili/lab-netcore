using System.Collections.Generic;
using Lab3.Models;

namespace Lab3.Data
{
    public interface IProdutosFake
    {
         IList<Produto> Produtos(int quantidade);
    }
}