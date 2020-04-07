using Around.Architectures.Core.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Around.Architectures.Core.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EntityConfigurations.CustomerEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.ProductEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.RowEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.OrderEntityTypeConfiguration());
        }
    }
}
