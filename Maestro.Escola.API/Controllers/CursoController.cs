using System.Collections.Generic;
using Maestro.Escola.Context;
using Maestro.Escola.Model;
using Microsoft.AspNetCore.Mvc;

namespace Maestro.Escola.API.Controllers
{
    [ApiController]
    [Route("Curso")]
    public class CursoController : ControllerBase
    {
        //Criat co seu context
        public CursoController()
        {
            //iniciar o seu contecto
        }

        
        public static List<Curso> minhaLista = new List<Curso>();

        [HttpPost]
        [Route("postCurso")]
        public ActionResult PostCurso(Curso Cursos)
        {
            //minhaLista.Add(Cursos);
            //context.Cursos.Where()
            new EscolaContext().Cursos.Add(Cursos);

            return Ok(minhaLista);
        }

        //[HttpPost]
        //[Route("GetGetBiruleiReinaldo")]
        //public ActionResult PostGetPessoaFisica(string NomePessoa)
        //{
        //    return Ok(minhaLista);
        //}

        //[HttpGet]
        //[Route("GetBiruleiReinaldo")]
        //public ActionResult GetPessoaFisica(string PessoaFisica)
        //{
        //    var result = new Result<List<Model.PessoaFisica>>();
        //    try
        //    {

        //        result.Data = minhaLista.Where(x => x.Nome.Contains(PessoaFisica)).ToList();


        //        if (result.Data.Count == 0)
        //        {
        //            result.Error = true;
        //            result.Message = Message.NoSuccess;
        //            result.Status = System.Net.HttpStatusCode.InternalServerError;

        //            return BadRequest(result);
        //        }
        //        else
        //        {
        //            result.Error = false;
        //            result.Message = Message.Success;
        //            result.Status = System.Net.HttpStatusCode.InternalServerError;

        //            return Ok(result);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Error = true;
        //        result.Message = Message.NoSuccess + ex.Message;
        //        result.Status = System.Net.HttpStatusCode.InternalServerError;

        //        return NotFound(result);
        //    }
        //}

        //[HttpDelete]
        //[Route("DeleteBiruleiReinaldo")]
        //public ActionResult DeletePessoaFisica(string PessoaFisica)
        //{
        //    try
        //    {
        //        var result = minhaLista.RemoveAll(x => x.Nome == PessoaFisica);

        //        if (result == 0)
        //            return BadRequest(Message.NoSuccess);
        //        else
        //            return Ok(Message.Success);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }

        //}

        //[HttpPut]
        //[Route("PutBiruleiReinaldo")]
        //public ActionResult PutPessoaFisica(string PessoaFisica, string NovaPessoaFisica)
        //{
        //    var result = new Result<List<Model.PessoaFisica>>();
        //    try
        //    {
        //        result.Data = minhaLista.Where(x => x.Nome == PessoaFisica).ToList();

        //        result.Data.Select(s =>
        //        {
        //            s.Nome = NovaPessoaFisica;
        //            return s;
        //        }).ToList();

        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Error = true;
        //        result.Message = ex.Message;
        //        return BadRequest(result);
        //    }

        //}
    }
}
