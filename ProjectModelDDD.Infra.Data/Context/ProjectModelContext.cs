
using Microsoft.EntityFrameworkCore;
using ProjectModelDDD.Domain.Entities;

namespace ProjectModelDDD.Infra.Data.Context
{
    public class ProjectModelContext : DbContext
    {
        public ProjectModelContext(DbContextOptions<ProjectModelContext> options)
            : base (options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>().HasKey(c => c.Id);
            modelBuilder.Entity<Client>().Property(c => c.FirstName).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Client>().Property(c => c.LastName).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Client>().Property(c => c.Email).IsRequired();

            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Product>().Property(p => p.Price).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(250);
            modelBuilder.Entity<Product>().HasOne(p => p.Client).WithMany().HasForeignKey(p => p.ClientId);
        }
    }
}
