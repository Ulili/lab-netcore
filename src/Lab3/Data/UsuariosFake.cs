using System;
using System.Collections.Generic;
using Lab3.Models;

namespace Lab3.Data
{
    internal class UsuariosFake : IUsuariosFake
    {
        public IList<Usuario> Usuarios(int quantidade)
        {
            var resultado = new List<Usuario>();
            Random rnd = new Random();
            var pedidos = new PedidosFake();

            if (quantidade > 0)
            {
                for (int i = 0; i < quantidade; i++)
                {
                    resultado.Add(new Usuario
                    {
                        Nome = $"Usuário dos Santos {quantidade}",
                        Id = i,
                        Pedidos = pedidos.Pedidos(rnd.Next(1, 20)) //Gerar inteiros aleatorios de 1 a 20
                    });
                }
            }

            return resultado;
        }
    }
}