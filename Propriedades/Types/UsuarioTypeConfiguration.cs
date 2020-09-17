using Maestro.Escola.Model;
using System.Data.Entity.ModelConfiguration;

namespace Maestro.Escola.Context.Types
{
    class UsuarioTypeConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioTypeConfiguration()
        {
            HasKey(q => q.IdUsuario);

            Property(q => q.NomeUsuario).HasMaxLength(50);
            Property(q => q.Senha);
            Property(q => q.Permissao);
        }
    }
}
