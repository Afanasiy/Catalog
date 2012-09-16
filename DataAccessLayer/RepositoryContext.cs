using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Catalog.Models;

namespace Catalog.DataAccessLayer
{
    public class RepositoryContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Block> Blocks { get; set; }

        public DbSet<Parameter> Parameters { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //one-to-many relationship between Category and SubCategory
            modelBuilder.Entity<Category>()
                .HasMany(category => category.SubCategories)
                .WithRequired(subcategories => subcategories.Category)
                .HasForeignKey(subcategories => subcategories.CategoryId)
                .WillCascadeOnDelete(true);

            //one-to-many relationship between SubCategory and Parameter
            modelBuilder.Entity<SubCategory>()
                .HasMany(subcategory => subcategory.Parameters)
                .WithRequired(parameter => parameter.SubCategory)
                .HasForeignKey(parameter => parameter.SubCategoryId)
                .WillCascadeOnDelete(true);

            //one-to-many relationship between Block and Parameter
            modelBuilder.Entity<Block>()
                .HasMany(block => block.Parameters)
                .WithRequired(parameter => parameter.Block)
                .HasForeignKey(parameter => parameter.BlockId)
                .WillCascadeOnDelete(true);

            //one-to-many relationship between Value and Parameter
            modelBuilder.Entity<Value>()
                .HasRequired(value => value.Parameter)
                .WithMany().
                HasForeignKey(value => value.ParameterId)
                .WillCascadeOnDelete(false);

            //one-to-many relationship between Item and Value
            modelBuilder.Entity<Item>()
                .HasMany(item => item.Values)
                .WithRequired(value => value.Item)
                .HasForeignKey(value => value.ItemId)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}