using Microsoft.EntityFrameworkCore;

namespace DesafioCodeFirst.DataModels
{
    internal class Context : DbContext
    {
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Note> Notas { get; set; }

        public Context() {}

        protected override void OnConfiguring(DbContextOptionsBuilder op)
        {
            op.UseSqlServer("Data Source=HGNOTEBOOK; Initial Catalog=dboDesafio; User ID=sa; password=12345; Language=Portuguese; Trust Server Certificate=true");
            op.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>()
                .HasOne(p => p.Fornecedor)
                .WithMany(f => f.Produtos)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<Note>()
                .HasOne(n => n.Produto)
                .WithMany(p => p.Notas)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<Note>()
                .HasOne(n => n.Cliente)
                .WithMany(c => c.Notas)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
