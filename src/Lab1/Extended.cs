using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    public static class Extended
    {
        
        public static string NormalizarNome( this string input ){

            if (!string.IsNullOrWhiteSpace( input))
            {
                return input.ToUpper().Replace("/", string.Empty);
            }

            return input;
        }

        public static IList<T> Paginar<T>( this IList<T> lista, int pagina, int limite) {
            return lista.Skip((pagina -1) * limite ).Take(pagina).ToList();
        }
    }
}