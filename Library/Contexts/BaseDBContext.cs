using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Contexts
{
    public class BaseDBContext<G> : DbContext where G : DbContext
    {
        public BaseDBContext()
        { }

        public BaseDBContext(DbContextOptions<G> options) : base(options)
        {
        }

        public DbSet<T> GetDbSetByType<T>() where T : class
        {
            return (DbSet<T>)this.GetType()
                            .GetProperties()
                            .Where(x => x.PropertyType.AssemblyQualifiedName == typeof(DbSet<T>).AssemblyQualifiedName)
                            .FirstOrDefault()
                            .GetValue(this);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}