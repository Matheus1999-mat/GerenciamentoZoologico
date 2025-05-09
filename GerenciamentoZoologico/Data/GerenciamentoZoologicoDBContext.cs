using GerenciamentoZoologico.Data.Map;
using GerenciamentoZoologico.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace GerenciamentoZoologico.Data
{
    public class GerenciamentoZoologicoDBContext: DbContext
    {
        public GerenciamentoZoologicoDBContext(DbContextOptions<GerenciamentoZoologicoDBContext> options) : base(options)
        {

        }
        public DbSet<Animais> Animais { get; set; }
        public DbSet<Cuidados> Cuidados { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnimaisMap());
            modelBuilder.ApplyConfiguration(new CuidadosMap());
        }
    }
}

