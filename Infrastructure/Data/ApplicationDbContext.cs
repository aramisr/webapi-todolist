using Microsoft.EntityFrameworkCore;
using Application.Common.Interfaces;
using Domain.Entities;

namespace Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options), IApplicationDbContext
{
    public DbSet<TodoList> TodoLists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoList>(entity =>
        {
            entity.ToTable("TodoLists");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.DateCreation)
             .HasColumnType("datetime2");

            entity.Property(e => e.DateEnd)
                  .HasColumnType("datetime2");

        });
        base.OnModelCreating(modelBuilder);
    }
}
