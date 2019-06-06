﻿// <auto-generated />
using System;
using BattleBoardGame.Model.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ModelBattleBoardGames.Migrations
{
    [DbContext(typeof(ModelJogosDeGuerra))]
    partial class ModelJogosDeGuerraModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BattleBoardGame.Model.Batalha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estado");

                    b.Property<int?>("ExercitoBrancoId");

                    b.Property<int?>("ExercitoPretoId");

                    b.Property<int?>("TabuleiroId");

                    b.Property<int?>("TurnoId");

                    b.Property<string>("UsuarioId");

                    b.Property<int?>("VencedorId");

                    b.HasKey("Id");

                    b.HasIndex("ExercitoBrancoId")
                        .IsUnique()
                        .HasFilter("[ExercitoBrancoId] IS NOT NULL");

                    b.HasIndex("ExercitoPretoId")
                        .IsUnique()
                        .HasFilter("[ExercitoPretoId] IS NOT NULL");

                    b.HasIndex("TabuleiroId")
                        .IsUnique()
                        .HasFilter("[TabuleiroId] IS NOT NULL");

                    b.HasIndex("TurnoId")
                        .IsUnique()
                        .HasFilter("[TurnoId] IS NOT NULL");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VencedorId")
                        .IsUnique()
                        .HasFilter("[VencedorId] IS NOT NULL");

                    b.ToTable("Batalhas");
                });

            modelBuilder.Entity("BattleBoardGame.Model.ElementoDoExercito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlcanceAtaque");

                    b.Property<int>("AlcanceMovimento");

                    b.Property<int>("Ataque");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("ExercitoId");

                    b.Property<int?>("ExercitoId1");

                    b.Property<int>("Saude");

                    b.Property<int>("TabuleiroId");

                    b.HasKey("Id");

                    b.HasIndex("ExercitoId");

                    b.HasIndex("ExercitoId1");

                    b.HasIndex("TabuleiroId");

                    b.ToTable("ElementosDoExercitos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ElementoDoExercito");
                });

            modelBuilder.Entity("BattleBoardGame.Model.Exercito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BatalhaId");

                    b.Property<int>("Nacao");

                    b.Property<string>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("BatalhaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Exercitos");
                });

            modelBuilder.Entity("BattleBoardGame.Model.Tabuleiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Altura");

                    b.Property<int>("Largura");

                    b.HasKey("Id");

                    b.ToTable("Tabuleiros");
                });

            modelBuilder.Entity("BattleBoardGame.Model.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("PrimeiroNome");

                    b.Property<string>("SobreNome");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BattleBoardGame.Model.Arqueiro", b =>
                {
                    b.HasBaseType("BattleBoardGame.Model.ElementoDoExercito");


                    b.ToTable("Arqueiro");

                    b.HasDiscriminator().HasValue("Arqueiro");
                });

            modelBuilder.Entity("BattleBoardGame.Model.Cavaleiro", b =>
                {
                    b.HasBaseType("BattleBoardGame.Model.ElementoDoExercito");


                    b.ToTable("Cavaleiro");

                    b.HasDiscriminator().HasValue("Cavaleiro");
                });

            modelBuilder.Entity("BattleBoardGame.Model.Guerreiro", b =>
                {
                    b.HasBaseType("BattleBoardGame.Model.ElementoDoExercito");


                    b.ToTable("Guerreiro");

                    b.HasDiscriminator().HasValue("Guerreiro");
                });

            modelBuilder.Entity("BattleBoardGame.Model.Batalha", b =>
                {
                    b.HasOne("BattleBoardGame.Model.Exercito", "ExercitoBranco")
                        .WithOne()
                        .HasForeignKey("BattleBoardGame.Model.Batalha", "ExercitoBrancoId");

                    b.HasOne("BattleBoardGame.Model.Exercito", "ExercitoPreto")
                        .WithOne()
                        .HasForeignKey("BattleBoardGame.Model.Batalha", "ExercitoPretoId");

                    b.HasOne("BattleBoardGame.Model.Tabuleiro", "Tabuleiro")
                        .WithOne()
                        .HasForeignKey("BattleBoardGame.Model.Batalha", "TabuleiroId");

                    b.HasOne("BattleBoardGame.Model.Exercito", "Turno")
                        .WithOne()
                        .HasForeignKey("BattleBoardGame.Model.Batalha", "TurnoId");

                    b.HasOne("BattleBoardGame.Model.Usuario")
                        .WithMany("Batalhas")
                        .HasForeignKey("UsuarioId");

                    b.HasOne("BattleBoardGame.Model.Exercito", "Vencedor")
                        .WithOne()
                        .HasForeignKey("BattleBoardGame.Model.Batalha", "VencedorId");
                });

            modelBuilder.Entity("BattleBoardGame.Model.ElementoDoExercito", b =>
                {
                    b.HasOne("BattleBoardGame.Model.Exercito", "Exercito")
                        .WithMany("Elementos")
                        .HasForeignKey("ExercitoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BattleBoardGame.Model.Exercito")
                        .WithMany("ElementosVivos")
                        .HasForeignKey("ExercitoId1");

                    b.HasOne("BattleBoardGame.Model.Tabuleiro", "Tabuleiro")
                        .WithMany("ElementosDoExercito")
                        .HasForeignKey("TabuleiroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("BattleBoardGame.Model.Posicao", "posicao", b1 =>
                        {
                            b1.Property<int?>("ElementoDoExercitoId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Altura");

                            b1.Property<int>("Largura");

                            b1.ToTable("ElementosDoExercitos");

                            b1.HasOne("BattleBoardGame.Model.ElementoDoExercito")
                                .WithOne("posicao")
                                .HasForeignKey("BattleBoardGame.Model.Posicao", "ElementoDoExercitoId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("BattleBoardGame.Model.Exercito", b =>
                {
                    b.HasOne("BattleBoardGame.Model.Batalha", "Batalha")
                        .WithMany()
                        .HasForeignKey("BatalhaId");

                    b.HasOne("BattleBoardGame.Model.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
