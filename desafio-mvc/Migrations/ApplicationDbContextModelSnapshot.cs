﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using desafio_mvc.Context;

namespace desafio_mvc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("desafio_mvc.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("desafio_mvc.Models.Ingrediente", b =>
                {
                    b.Property<int>("IngredienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("UnidadeDeMedidaMedidaId")
                        .HasColumnType("int");

                    b.HasKey("IngredienteId");

                    b.HasIndex("UnidadeDeMedidaMedidaId");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("desafio_mvc.Models.LogginModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeDeAcesso")
                        .HasColumnType("int");

                    b.Property<int?>("ReceitaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Loggins");
                });

            modelBuilder.Entity("desafio_mvc.Models.Medida", b =>
                {
                    b.Property<int>("MedidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Simbolo")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("MedidaId");

                    b.ToTable("Medidas");
                });

            modelBuilder.Entity("desafio_mvc.Models.Receita", b =>
                {
                    b.Property<int>("ReceitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("Dificuldade")
                        .HasColumnType("int");

                    b.Property<string>("ImagemUrl")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<bool>("IsPreferido")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ModoDePreparo")
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NomeDoAutor")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<int>("Rendimento")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("TempoDePreparo")
                        .HasColumnType("float");

                    b.HasKey("ReceitaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("desafio_mvc.Models.ReceitaIngrediente", b =>
                {
                    b.Property<int>("IngredienteId")
                        .HasColumnType("int");

                    b.Property<int>("ReceitaId")
                        .HasColumnType("int");

                    b.Property<double>("QuantidadeDeIngrediente")
                        .HasColumnType("double");

                    b.Property<int?>("ReceitaIngredienteIngredienteId")
                        .HasColumnType("int");

                    b.Property<int?>("ReceitaIngredienteReceitaId")
                        .HasColumnType("int");

                    b.HasKey("IngredienteId", "ReceitaId");

                    b.HasIndex("ReceitaId");

                    b.HasIndex("ReceitaIngredienteIngredienteId", "ReceitaIngredienteReceitaId");

                    b.ToTable("ReceitaIngredientes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("desafio_mvc.Models.Ingrediente", b =>
                {
                    b.HasOne("desafio_mvc.Models.Medida", "UnidadeDeMedida")
                        .WithMany()
                        .HasForeignKey("UnidadeDeMedidaMedidaId");

                    b.Navigation("UnidadeDeMedida");
                });

            modelBuilder.Entity("desafio_mvc.Models.Receita", b =>
                {
                    b.HasOne("desafio_mvc.Models.Categoria", "Categoria")
                        .WithMany("Receitas")
                        .HasForeignKey("CategoriaId");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("desafio_mvc.Models.ReceitaIngrediente", b =>
                {
                    b.HasOne("desafio_mvc.Models.Ingrediente", "Ingrediente")
                        .WithMany("Receitas")
                        .HasForeignKey("IngredienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("desafio_mvc.Models.Receita", "Receita")
                        .WithMany("Ingrediente")
                        .HasForeignKey("ReceitaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("desafio_mvc.Models.ReceitaIngrediente", null)
                        .WithMany("ReceitaIngredientes")
                        .HasForeignKey("ReceitaIngredienteIngredienteId", "ReceitaIngredienteReceitaId");

                    b.Navigation("Ingrediente");

                    b.Navigation("Receita");
                });

            modelBuilder.Entity("desafio_mvc.Models.Categoria", b =>
                {
                    b.Navigation("Receitas");
                });

            modelBuilder.Entity("desafio_mvc.Models.Ingrediente", b =>
                {
                    b.Navigation("Receitas");
                });

            modelBuilder.Entity("desafio_mvc.Models.Receita", b =>
                {
                    b.Navigation("Ingrediente");
                });

            modelBuilder.Entity("desafio_mvc.Models.ReceitaIngrediente", b =>
                {
                    b.Navigation("ReceitaIngredientes");
                });
#pragma warning restore 612, 618
        }
    }
}
