using System;
using System.Collections.Generic;
using DnetLibrary.Domain;
using Microsoft.EntityFrameworkCore;

namespace DnetLibrary.EfModels.Contexts;

public partial class MountainContext : DbContext
{
    public DbSet<Mountain> Mountains { get; set; }

    public MountainContext()
    {
    }

    public MountainContext(DbContextOptions<MountainContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=ConnectionStrings:dnetdb");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
