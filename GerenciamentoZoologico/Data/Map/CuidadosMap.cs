using GerenciamentoZoologico.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoZoologico.Data.Map
{
    public class CuidadosMap : IEntityTypeConfiguration<Cuidados>
    {
        public void Configure(EntityTypeBuilder<Cuidados> builder)
        {
            builder.HasKey(e => e.CuidadoId);
            builder.Property(e => e.NomeCuidado).IsRequired();
            builder.Property(e => e.Descricao).IsRequired();
            builder.Property(e => e.Frequencia).IsRequired();
        }
    }
}
