
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
    }
}
