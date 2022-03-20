using Hdogs.api.Model.Entity;
using Library.Contexts;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Hdogs.api.Model.Context
{
    public class MySqlContext : BaseDBContext<MySqlContext>
    {

        public DbSet<AuthData> AuthDatas { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Entity.Monitor> Monitors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Pet> Services { get; set; }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthData>()
                        .HasIndex(x => x.Email)
                        .IsUnique();

            modelBuilder.Entity<DocumentType>()
                        .HasIndex(x => x.Value)
                        .IsUnique();
        }
    }
}