using System.Collections.Generic;

namespace Maestro.Escola.Model
{
    public class Materia
    {
        public string NomeMateria { get; set; }
        public int IdMateria { get; set; }
        public int IdCurso { get; set; }
        public string SituacaoMateria { get; set; }
        public virtual Curso Cursos { get; set; }
        public virtual ICollection<Nota> Notas { get; set; } = new HashSet<Nota>();
    }
}
