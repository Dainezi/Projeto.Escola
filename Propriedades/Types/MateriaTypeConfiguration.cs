using Maestro.Escola.Model;
using System.Data.Entity.ModelConfiguration;

namespace Maestro.Escola.Context.Types
{
    class MateriaTypeConfiguration : EntityTypeConfiguration<Materia>
    {
        public MateriaTypeConfiguration()
        {
            HasKey(q => q.IdMateria);

            Property(q => q.NomeMateria).HasMaxLength(100);
            Property(q => q.SituacaoMateria).HasMaxLength(20);

            HasRequired(q => q.Cursos).WithMany().HasForeignKey(q => q.IdCurso);

            HasMany(q => q.Notas).WithRequired().HasForeignKey(q => q.IdMateria);
        }
    }
}
