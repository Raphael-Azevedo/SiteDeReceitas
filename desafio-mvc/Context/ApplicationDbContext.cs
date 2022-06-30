using System;
using System.Collections.Generic;
using System.Text;
using desafio_mvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace desafio_mvc.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<LogginModels> Loggins { get; set; }
        public DbSet<Medida> Medidas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<ReceitaIngrediente> ReceitaIngredientes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceitaIngrediente>().HasKey(sc => new {sc.IngredienteId, sc.ReceitaId});
            modelBuilder.Entity<Categoria>()
                .Property(p => p.Nome)
                    .HasMaxLength(100);
            modelBuilder.Entity<Categoria>()
                .Property(p => p.Descricao)
                    .HasMaxLength(450);

            modelBuilder.Entity<Medida>()
                .Property(p => p.Nome)
                    .HasMaxLength(100);
            modelBuilder.Entity<Medida>()
                .Property(p => p.Simbolo)
                    .HasMaxLength(50);

            modelBuilder.Entity<Ingrediente>()
                .Property(p => p.Nome)
                    .HasMaxLength(100);

            modelBuilder.Entity<Receita>()
                .Property(p => p.Nome)
                    .HasMaxLength(100);
            modelBuilder.Entity<Receita>()
                .Property(p => p.ModoDePreparo)
                    .HasMaxLength(4000);
            modelBuilder.Entity<Receita>()
                .Property(p => p.ImagemUrl)
                    .HasMaxLength(250);
            modelBuilder.Entity<Receita>()
                .Property(p => p.NomeDoAutor)
                    .HasMaxLength(150);
            modelBuilder.Entity<Receita>()
                .Property(p => p.Rendimento)
                    .HasMaxLength(50);
                    
            base.OnModelCreating(modelBuilder);
        }
    }
}
