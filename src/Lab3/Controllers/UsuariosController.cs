using System;
using System.Collections.Generic;
using System.Linq;
using Lab3.Data;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsuariosController : ControllerBase
    {
        public readonly DadosFake db;

        public UsuariosController(DadosFake _db){
            db =_db;
        }

        [HttpGet("listar")]
        public ActionResult<IList<Usuario>> Listar()
        {
            var db = new DadosFake();

            return db.Usuarios(1).ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> Obter(int id){
            return db.Usuarios(10).Where(w=> w.Id == id).FirstOrDefault();
        }
    }
}