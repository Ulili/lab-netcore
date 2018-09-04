using System;
using System.Collections.Generic;
using System.Linq;
using Lab3.Data;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{

    /// <summary>
    /// Ctrl de usuário
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class UsuariosController : ControllerBase
    {
        public readonly IUsuariosFake db;

        public UsuariosController(IUsuariosFake _db){
            db =_db;
        }

        /// <summary>
        /// Listar todos os usuários
        /// </summary>
        /// <returns></returns>
        [HttpGet("listar")]
        public ActionResult<IList<Usuario>> Listar()
        {
            return db.Usuarios(1).ToList();
        }


        /// <summary>
        /// Obter usuário por id
        /// </summary>
        /// <param name="id">id desejado</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<Usuario> Obter(int id){
            return db.Usuarios(10).Where(w=> w.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Insluir um novo usuário
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(Usuario), 200)]
        [ProducesResponseType(typeof(Mensagem), 400)]
        public ActionResult<Usuario> Inserir([FromBody] Usuario usuario ){

            //Exemplo de validação de negócio
            if (usuario.Id == 10)
            {
                return new BadRequestObjectResult(new Mensagem{ Code=30000, Msg ="Msg usuário não pode ter Id 10" });
            }
            return usuario;
        }
    }
}