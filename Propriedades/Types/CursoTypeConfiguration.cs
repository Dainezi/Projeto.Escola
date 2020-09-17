using System.Data.Entity.ModelConfiguration;
using Maestro.Escola.Model;

namespace Maestro.Escola.Context.Types
{
    public class CursoTypeConfiguration : EntityTypeConfiguration<Curso>
    {
        public CursoTypeConfiguration()
        {
            HasKey(q => q.IdCurso);

            Property(q => q.NomeCurso).HasMaxLength(100);
            Property(q => q.SituacaoCurso).HasMaxLength(20);

            HasMany(q => q.Alunos).WithRequired().HasForeignKey(q => q.IdCurso);
            HasMany(q => q.Materias).WithRequired().HasForeignKey(q => q.IdCurso);
            HasMany(q => q.Notas).WithRequired().HasForeignKey(q => q.IdCurso);
        }

    }
}
