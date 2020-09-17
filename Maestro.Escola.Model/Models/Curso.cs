using System.Collections.Generic;

namespace Maestro.Escola.Model
{
    public class Curso
    {
        public string NomeCurso { get; set; }
        public int IdCurso { get; set; }
        public string SituacaoCurso { get; set; }

        public virtual ICollection<Materia> Materias { get; set; } = new HashSet<Materia>();
        public virtual ICollection<Aluno> Alunos { get; set; } = new HashSet<Aluno>();
        public virtual ICollection<Nota> Notas { get; set; } = new HashSet<Nota>();
    }
}
