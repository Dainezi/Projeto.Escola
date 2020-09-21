using Maestro.Escola.Context;
using Maestro.Escola.Context.Utilitario;
using Maestro.Escola.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Maestro.Escola.API.Controllers
{
    [ApiController]
    [Route("Materia")]
    public class MateriaController : ControllerBase
    {
        public MateriaController()
        {
            //iniciar o seu contecto
        }

        [HttpPost]
        [Route("postMateria")]
        public ActionResult PostCurso(Materia Materias)
        {
            new EscolaContext().Materias.Add(Materias);

            return Ok(Materias);
        }

        [HttpPost]
        [Route("postAlterarMateria")]
        public ActionResult PostAlterarCurso(Materia Materias)
        {
            new EscolaContext().Materias.Add(Materias);

            return Ok(Materias);
        }

        [HttpDelete]
        [Route("deleteMateria")]
        public ActionResult DeleteMateria(Materia Materias)
        {
            try
            {
                new EscolaContext().Materias.Remove(Materias);

                return Ok(Message.Success);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}