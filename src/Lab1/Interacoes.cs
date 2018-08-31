using System;
using System.Collections.Generic;
using System.Linq;
using Lab1.Models;

namespace Lab1
{
    public class Interacoes
    {

        #region Yeld

        /// <summary>
        /// Exemplo de implementação de interação com Yeld
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Usuario> YieldSample()
        {

            for (int count = 0; count < 10; count++)
            {
                yield return new Usuario { Id = count, Nome = $"Nome_{count}" };
            }
        }
        #endregion

        #region Delegate

        delegate double OperacaoMatematica(double numero);

        /// <summary>
        /// Teste de Delegator
        /// </summary>
        public void DelegatorSample()
        {
            //Delegator
            OperacaoMatematica operador = Dobro;
            Console.WriteLine($"Dobro => { operador(2)}");

            //Metodo anonimo
            operador = delegate (double num)
            {
                return num * num;
            };

            Console.WriteLine($"Quadrado => { operador(4)}");

            //Delegate com Lamda Expression
            operador = num => num + 10;
        }

        private double Dobro(double input)
        {
            return input * 2;
        }

        // delegate void CustomDel(string s);
        public void DelegatorMulti()
        {
            // CustomDel hiDel, byeDel, multiDel, multiMinusHiDel;
            Action<string> hiDel, byeDel, multiDel, multiMinusHiDel;

            // Create the delegate object hiDel that references the
            // method Hello.
            hiDel = Hello;

            // Create the delegate object byeDel that references the
            // method Goodbye.
            byeDel = Goodbye;

            // The two delegates, hiDel and byeDel, are combined to
            // form multiDel.
            multiDel = hiDel + byeDel;

            // Remove hiDel from the multicast delegate, leaving byeDel,
            // which calls only the method Goodbye.
            multiMinusHiDel = multiDel - hiDel;

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");
            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("B");
            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("C");
            Console.WriteLine("Invoking delegate multiMinusHiDel:");
            multiMinusHiDel("D");
        }

        void Goodbye(string s)
        {
            System.Console.WriteLine("  Goodbye, {0}!", s);
        }

        void Hello(string s)
        {
            System.Console.WriteLine("  Hello, {0}!", s);
        }
        #endregion

        #region Func, Action e Expression

        public void FuncTeste()
        {
            Func<int, bool> comparador = x => x == 5;
            bool result = comparador(4);

            Console.WriteLine($"Resultado =>{result}");

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int impares = numbers.Count(nn=> nn % 2 == 1 );
            var todosImpares = numbers.Where(nn=> nn % 2 == 1 ).ToList();

            int pares = numbers.Count(numerosPares());
            var todosPares = numbers.Where(numerosPares()).ToList();
            Console.WriteLine($"Num Pares => {Newtonsoft.Json.JsonConvert.SerializeObject(todosPares)}");
            Console.WriteLine($"Num Impares => {Newtonsoft.Json.JsonConvert.SerializeObject(todosImpares)}");

        }

        private Func<int, bool> numerosPares()
        {
            return n =>
            {
                //executa qualquer logica..

               return n % 2 == 0; //Verifica numeros pares
            };
        }

        #endregion
    }
}