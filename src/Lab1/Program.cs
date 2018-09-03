using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab.Dados.Colecoes;
using Lab.Dados.Models;
using Newtonsoft.Json;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            // var arry = new int[] { 1, 2, 4, 5, 6, 7, 2000, 20 };
            // var arry2 = new int[] { 4, 5, 6, 7, 2000, 20, 90000,20202 };
            // var novo = arry.Intersect(arry2);
            DadosFake dados = new DadosFake();

            // var usuarios = dados.Usuarios(10);
            // var resultado = (from d in usuarios 
            //                 from a in arry
            //                 where d.Id == a
            //                 select new {
            //                     d.Nome,
            //                     d.DataNascimento
            //                 }).AsQueryable();
                            
            // var total = resultado.Count();
            // var primeiro = resultado.FirstOrDefault();
            // System.Console.WriteLine($"Total => {total}" );            

            // System.Console.WriteLine(JsonConvert.SerializeObject(resultado.ToList()));
                            
            var nome = "Fulano da sILVA jUnior";

            var nome2 = nome.NormalizarNome();

            var lista = dados.Usuarios(1000);
            var paginado = lista.Paginar(1, 50);

            System.Console.WriteLine(JsonConvert.SerializeObject(paginado));
            System.Console.WriteLine(paginado.Count());

        }

        public static async Task Executar()
        {
            var reuslts = await Task.WhenAll(
                 TarefaMin(),
                 TarefaMax()
            );

            System.Console.WriteLine(JsonConvert.SerializeObject( reuslts ));
        }

        public static async Task<int> TarefaMin()
        {
            var arry = new int[] { 1, 2, 4, 5, 6, 7, 2000, 20 };
            return arry.Min();
        }

        public static async Task<int> TarefaMax()
        {
            var arry = new int[] { 1, 2, 4, 5, 6, 7, 2000, 20 };
            var (a,b) = ExemploT();            

            return arry.Max();
        }

        public static (string , int) ExemploT(){

            return ("", 11);
        }
    }
}
