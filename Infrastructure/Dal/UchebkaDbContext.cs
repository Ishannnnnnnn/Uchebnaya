using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Dal;

public class UchebkaDbContext : DbContext
{
    public DbSet<User> Users { get; init; }
    
    public DbSet<Water> Waters { get; init; }
    
    public DbSet<Gas> Gases { get; init; }
    
    public DbSet<Electricity> Electricities { get; init; }
    
    
    public UchebkaDbContext(DbContextOptions<UchebkaDbContext> options) : base(options)
    {
    }

    public UchebkaDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseNpgsql(
            "User ID=postgres;Password=7733;Host=localhost;Port=5432;Database=Uchebka;");
    }

    /// <summary>
    /// Метод применения конфигураций
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UchebkaDbContext).Assembly);
    }
}