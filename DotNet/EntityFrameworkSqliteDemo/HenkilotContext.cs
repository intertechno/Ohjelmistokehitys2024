using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkSqliteDemo;

public partial class HenkilotContext : DbContext
{
    public HenkilotContext()
    {
    }

    public HenkilotContext(DbContextOptions<HenkilotContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Henkilot> Henkilots { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=Henkilot.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Henkilot>(entity =>
        {
            entity.HasKey(e => e.HenkiloId);

            entity.ToTable("Henkilot");

            entity.Property(e => e.HenkiloId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
