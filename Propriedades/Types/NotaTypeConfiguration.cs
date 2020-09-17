using Maestro.Escola.Model;
using System.Data.Entity.ModelConfiguration;

namespace Maestro.Escola.Context.Types
{
    class NotaTypeConfiguration : EntityTypeConfiguration<Nota>
    {
        public NotaTypeConfiguration()
        {
            Property(q => q.NotaAluno);
            Property(q => q.NomeMateria);

            HasRequired(q => q.Cursos).WithMany().HasForeignKey(q => q.IdCurso);
            HasRequired(q => q.Materias).WithMany().HasForeignKey(q => q.IdMateria);
            HasRequired(q => q.Alunos).WithMany().HasForeignKey(q => q.IdAluno);

        }
    }
}
