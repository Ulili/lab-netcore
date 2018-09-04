using System.Collections.Generic;
using Lab3.Models;

namespace Lab3.Data
{
    public interface IUsuariosFake
    {
        IList<Usuario> Usuarios(int quantidade);
    }
}