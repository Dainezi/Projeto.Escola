using Maestro.Escola.Model;
using System.Data.Entity.ModelConfiguration;

namespace Maestro.Escola.Context.Types
{
    class AlunoTypeConfiguration : EntityTypeConfiguration<Aluno>
    {
        public AlunoTypeConfiguration()
        {
            HasKey(q => q.IdAluno);

            Property(q => q.NomeAluno).HasMaxLength(100);
            Property(q => q.IdMateria);
            Property(q => q.CpfAluno).HasMaxLength(14);
            Property(q => q.DataNascAluno).HasMaxLength(10);
            Property(q => q.SituacaoAluno).HasMaxLength(20);

            HasRequired(q => q.Cursos).WithMany().HasForeignKey(q => q.IdCurso);

            HasMany(q => q.Notas).WithRequired().HasForeignKey(q => q.IdAluno);
        }
    }
}
