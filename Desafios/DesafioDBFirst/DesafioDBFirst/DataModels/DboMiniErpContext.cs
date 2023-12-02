using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DesafioDBFirst.DataModels;

public partial class DboMiniErpContext : DbContext
{
    public DboMiniErpContext()
    {
    }

    public DboMiniErpContext(DbContextOptions<DboMiniErpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clients { get; set; }

    public virtual DbSet<Fornecedores> Fornecedores { get; set; }

    public virtual DbSet<NotaCliente> NotaClientes { get; set; }

    public virtual DbSet<NotaProd> NotaProds { get; set; }

    public virtual DbSet<Nota> Nota { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=HGNOTEBOOK;Initial Catalog=dboMiniERP;Persist Security Info=True;User ID=MiniERP;Password=MiniERP123;Encrypt=False;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clients__3213E83F20F69169");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cpf).HasColumnName("cpf");
            entity.Property(e => e.DatNasc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("datNasc");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Fornecedores>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Forneced__3213E83F08CDFA29");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cnpj");
            entity.Property(e => e.DatCriacao)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("datCriacao");
            entity.Property(e => e.Funcao)
                .HasColumnType("text")
                .HasColumnName("funcao");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<NotaCliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nota_cliente");

            entity.Property(e => e.FkClientId).HasColumnName("fk_clientId");
            entity.Property(e => e.FkNotaId).HasColumnName("fk_notaId");

            entity.HasOne(d => d.FkClient).WithMany()
                .HasForeignKey(d => d.FkClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__nota_clie__fk_cl__440B1D61");

            entity.HasOne(d => d.FkNota).WithMany()
                .HasForeignKey(d => d.FkNotaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__nota_clie__fk_no__4316F928");
        });

        modelBuilder.Entity<NotaProd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nota_prod");

            entity.Property(e => e.FkNotaId).HasColumnName("fk_notaId");
            entity.Property(e => e.FkProdId).HasColumnName("fk_prodId");

            entity.HasOne(d => d.FkNota).WithMany()
                .HasForeignKey(d => d.FkNotaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__nota_prod__fk_no__412EB0B6");

            entity.HasOne(d => d.FkProd).WithMany()
                .HasForeignKey(d => d.FkProdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__nota_prod__fk_pr__4222D4EF");
        });

        modelBuilder.Entity<Nota>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Nota__3213E83F3F4C0C31");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DatCompra)
                .HasColumnType("date")
                .HasColumnName("datCompra");
            entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
            entity.Property(e => e.FkProd).HasColumnName("fk_prod");
            entity.Property(e => e.MetPagamento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("metPagamento");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Produtos__3213E83F53C6D2B9");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasColumnType("text")
                .HasColumnName("descricao");
            entity.Property(e => e.FkForn).HasColumnName("fk_forn");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Preco)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("preco");

            entity.HasOne(d => d.FkFornNavigation).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.FkForn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Produtos__fk_for__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
