using ContainRs.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContainRs.WebApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<User>()
            .Property(c => c.Name).IsRequired();
        modelBuilder.Entity<User>()
            .Property(c => c.Email).IsRequired();
        modelBuilder.Entity<User>()
            .Property(c => c.CPF).IsRequired();
    }
}
