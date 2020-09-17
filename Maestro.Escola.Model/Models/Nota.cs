namespace Maestro.Escola.Model
{
    public class Nota
    {
        public string NomeMateria { get; set; }
        public int IdMateria { get; set; }
        public int IdCurso { get; set; }
        public int IdAluno { get; set; }
        public int NotaAluno { get; set; }

        public virtual Curso Cursos { get; set; }
        public virtual Aluno Alunos { get; set; }
        public virtual Materia Materias { get; set; }
    }
}
