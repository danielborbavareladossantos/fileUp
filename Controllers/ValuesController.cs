using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace upFile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromForm] postComunicado body)
        {
            //informações do arquivo
            String tipoArquivo = body.Arquivo.ContentType;
            String nomeArquivo = body.Arquivo.FileName;

            //informações enviadas junto ao arquivo
            String nome = body.Nome;
            Int64 idComunicado = body.Id_comunicado;

            this.leituraFile(body.Arquivo);

            return "Arquivo gerado!";
        }

        async public void leituraFile(IFormFile file) {
            using(var stream = file.OpenReadStream()) {
                Console.WriteLine(stream);
            }
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
