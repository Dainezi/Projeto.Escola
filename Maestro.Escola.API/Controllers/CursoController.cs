using System;
using System.Collections.Generic;
using Maestro.Escola.Context;
using Maestro.Escola.Context.Utilitario;
using Maestro.Escola.Model;
using Microsoft.AspNetCore.Mvc;

namespace Maestro.Escola.API.Controllers
{
    [ApiController]
    [Route("Curso")]
    public class CursoController : ControllerBase
    {
        public CursoController()
        {
            //iniciar o seu contecto
        }

               [HttpPost]
        [Route("postCurso")]
        public ActionResult PostCurso(Curso Cursos)
        {
            new EscolaContext().Cursos.Add(Cursos);

            return Ok(Cursos);
        }

        [HttpPost]
        [Route("postAlterarCurso")]
        public ActionResult PostAlterarCurso(Curso Cursos)
        {
            new EscolaContext().Cursos.Add(Cursos);

            return Ok(Cursos);
        }

        [HttpDelete]
        [Route("deleteCurso")]
        public ActionResult DeleteCurso(Curso Cursos)
        {
            try
            {
                new EscolaContext().Cursos.Remove(Cursos);

                return Ok(Message.Success);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
