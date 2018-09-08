using Lab4.Data;
using Lab4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4.Services
{
    public class UsuarioServices
    {
        public readonly DadosContext dbContext;

        public UsuarioServices(DadosContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IList<Usuario>> UsuarioPedidos(){
            
            var usuarios = dbContext.Usuarios.ToList();

            Parallel.ForEach(usuarios, item=> {
                item.CPF = item.Nome + item.Id;
            });

            return dbContext.Usuarios
            .Where(ww=> ww.Pedidos.Any() && ww.DataNascimento < DateTime.Now)
            .ToList();

        }
    }
}