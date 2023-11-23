﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WannaBuy.Models.Domain;

namespace WannaBuy.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasMany(x => x.Products)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Applications)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.User_Id);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.User_Id);

            modelBuilder.Entity<Filter>()
                .HasMany(x => x.Applications)
                .WithOne(x => x.Filter)
                .HasForeignKey(x => x.Filter_id);

            modelBuilder.Entity<Application>()
                .HasOne(x => x.Product)
                .WithOne(x => x.Application)
                .HasForeignKey<Product>(x => x.Application_id);

            modelBuilder.Entity<Application>()
                .HasMany(x => x.Comments)
                .WithOne(x => x.Application)
                .HasForeignKey(x => x.Application_id);
        }
    }
}