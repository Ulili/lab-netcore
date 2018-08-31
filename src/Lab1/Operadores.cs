using System;
using System.Collections.Generic;
using System.Linq;
using Lab1.Models;

namespace Lab1
{
    public class Operadores
    {

        /// <summary>
        /// Exemplo de multideclaração, multi atribuição e oeradores
        /// </summary>
        public void Teste()
        {
            int a, b, c, d;
            a = b = c = d = 10;
            c /= 2;

            Console.WriteLine($"a=> {a++} b=> {++b} c=> {c} d=> {d + 6}");
            Console.WriteLine($"a=> {a}");
        }

        /// <summary>
        /// Lamda operator =>
        /// </summary>
        public void Teste2()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int shortestWordLength = words.Min(w => w.Length);
            Console.WriteLine(shortestWordLength);

            var query = from w in words
                        select w.Length;

            int shortestWordLength2 = query.Min();
            Console.WriteLine(shortestWordLength2);

        }

        /// <summary>
        /// Teste do operador ?. and ?[] null-conditional
        /// </summary>
        public void Teste3()
        {

            var usuarios = new Usuario[2];
            var tamanho = usuarios?.Length;
            var primeiro = usuarios?[0];
            int? totalPedidos = usuarios?[0]?.Pedidos?.Count();

            Console.WriteLine($"tamanho => {tamanho}, Nome do Primeiro=> {primeiro?.Nome}, Produtos do Primeiro => {totalPedidos}");

            usuarios[0] = new Usuario
            {
                Id = 11,
                Nome = "Fulano",
                Pedidos = new List<Pedido>{
                new Pedido{ Id = Guid.NewGuid(), Descricao="Teste 1"}
                }
            };

            tamanho = usuarios?.Length;
            primeiro = usuarios?[0];
            totalPedidos = usuarios?[0].Pedidos?.Count();

            Console.WriteLine($"tamanho => {tamanho}, Nome do Primeiro=> {primeiro?.Nome}, Produtos do Primeiro => {totalPedidos}");
        }
    }
}