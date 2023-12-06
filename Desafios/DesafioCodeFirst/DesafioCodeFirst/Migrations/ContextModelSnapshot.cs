﻿// <auto-generated />
using System;
using DesafioCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesafioCodeFirst.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DesafioCodeFirst.DataModels.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("DesafioCodeFirst.DataModels.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Funcao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("DesafioCodeFirst.DataModels.Note", b =>
                {
                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdProd")
                        .HasColumnType("int");

                    b.HasKey("IdCliente", "IdProd");

                    b.HasIndex("IdProd");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("DesafioCodeFirst.DataModels.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("DesafioCodeFirst.DataModels.Note", b =>
                {
                    b.HasOne("DesafioCodeFirst.DataModels.Cliente", "Cliente")
                        .WithMany("Notas")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("DesafioCodeFirst.DataModels.Produto", "Produto")
                        .WithMany("Notas")
                        .HasForeignKey("IdProd")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("DesafioCodeFirst.DataModels.Produto", b =>
                {
                    b.HasOne("DesafioCodeFirst.DataModels.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("DesafioCodeFirst.DataModels.Cliente", b =>
                {
                    b.Navigation("Notas");
                });

            modelBuilder.Entity("DesafioCodeFirst.DataModels.Fornecedor", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("DesafioCodeFirst.DataModels.Produto", b =>
                {
                    b.Navigation("Notas");
                });
#pragma warning restore 612, 618
        }
    }
}
