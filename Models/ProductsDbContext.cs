using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProductApp.Models;

public partial class ProductsDbContext : DbContext
{
    public ProductsDbContext()
    {
    }

    public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("varchar(10)");
            entity.Property(e => e.quantity).HasColumnType("int");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
