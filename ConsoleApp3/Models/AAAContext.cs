﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3.Models;

public partial class AAAContext : DbContext
{
    public AAAContext(DbContextOptions<AAAContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestVarchar> TestVarchar { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TestVarchar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TestVarc__3214EC0707E6D063");

            entity.Property(e => e.Tname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TName");
            entity.Property(e => e.Tvalue).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}