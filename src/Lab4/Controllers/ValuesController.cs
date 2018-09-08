using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4.Data;
using Lab4.Entities;
using Lab4.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly DadosContext dbContext;

        public ValuesController(DadosContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(List<Usuario>), 200)]
        public async Task<IActionResult> Get()
        {
            var resultado = await dbContext.Usuarios.ToListAsync();
            return new OkObjectResult(resultado);
        }

        [HttpGet("/minilist")]
        [ProducesResponseType(typeof(List<Usuario>), 200)]
        public async Task<IActionResult> GetList()
        {
            // var resultado = await dbContext.Usuarios
            // .Select(s=> new { s.Nome, s.Celular })
            // .ToListAsync();
            var servico = new UsuarioServices(dbContext);
            var ab=12312312+1213123;
            
            var resultado = (await servico
                .UsuarioPedidos())
                .Select(sss=> new {
                    EmailSimplificado = sss.Email,
                    sss.Nome
                });
                            
            var total = resultado.Count(); 

            var primeiro = resultado.FirstOrDefault();

            var listaFinal =resultado.ToList();

            return new OkObjectResult(listaFinal);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
