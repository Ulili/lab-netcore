using System;
using Lab.Dados.Colecoes;
using Newtonsoft.Json;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var interacoes = new Interacoes();
            var colecoes = interacoes.YieldSample();
            // Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(colecoes));

            var operador = new Operadores();

            operador.Teste3();
            interacoes.DelegatorSample();
            interacoes.DelegatorMulti();
            interacoes.FuncTeste();

           var fakeData = new DadosFake();
           var usuarios = fakeData.Usuarios(100);

           System.Console.WriteLine(JsonConvert.SerializeObject( usuarios ));

        }
    }
}
