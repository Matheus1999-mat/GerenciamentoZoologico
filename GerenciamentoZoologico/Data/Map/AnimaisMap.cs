using GerenciamentoZoologico.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoZoologico.Data.Map
{
    public class AnimaisMap : IEntityTypeConfiguration<Animais>
    {
        public void Configure(EntityTypeBuilder<Animais> builder)
        {
            builder.HasKey(e => e.AnimalId);
            builder.Property(e => e.Nome).IsRequired();
            builder.Property(e => e.CuidadoID).IsRequired();
            builder.Property(e => e.Descricao).IsRequired();
            builder.Property(e => e.DataNascimento).IsRequired();
            builder.Property(e => e.Especie).IsRequired();
            builder.Property(e => e.Habitat).IsRequired();
            builder.Property(e => e.PaisOrigem).IsRequired();



            builder.HasOne<Cuidados>()
        .WithMany()
        .HasForeignKey(e => e.CuidadoID);
        }
    }



}
    

