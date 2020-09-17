using System.Collections.Generic;

namespace Maestro.Escola.Model
{
    public class Aluno
    {
        public string NomeAluno { get; set; }
        public int IdAluno { get; set; }
        public string CpfAluno { get; set; }
        public string DataNascAluno { get; set; }
        public int IdCurso { get; set; }
        public int IdMateria { get; set; }
        public string SituacaoAluno { get; set; }

        public virtual Curso Cursos { get; set; }
        public virtual ICollection<Nota> Notas { get; set; } = new HashSet<Nota>();

    }
}
