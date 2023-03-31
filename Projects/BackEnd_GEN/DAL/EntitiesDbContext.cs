 //
// GENERATED CODE DO NOT UPDATE
// Telosys Template : csharp-backend / DAL / EntitiesDbContext_cs.vm
// Patterns : DBContext for Entity Framework
// Created on 2023-03-10 - Time 16:46:08 
// Generated by : csharp-backend 
// Generated by : Telosys Tools Generator 4.0.0
//

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using CarModel.Entities;

namespace CarModel.Models
{
	public class EntitiesDbContext : DbContext
	{
		public EntitiesDbContext()
		{
        	var path = Environment.CurrentDirectory;
        	DbPath = System.IO.Path.Join(path, "CarModel.db");
		}

        public EntitiesDbContext(DbContextOptions<EntitiesDbContext> options)
            : base(options)
        {
        }

        // Database path
        public string DbPath { get; }

		public DbSet<Comment> Comments { get; set; }
		public DbSet<Post> Posts { get; set; }

        //
        // Summary:
        //     Override this method to configure the database (and other options) to be used
        //     for this context. This method is called for each instance of the context that
        //     is created. The base implementation does nothing.
        //
        // Parameters:
        //   optionsBuilder:
        //     A builder used to create or modify options for this context. Databases (and other
        //     extensions) typically define extension methods on this object that allow you
        //     to configure the context.
        //
        // Remarks:
        //     In situations where an instance of Microsoft.EntityFrameworkCore.DbContextOptions
        //     may or may not have been passed to the constructor, you can use Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.IsConfigured
        //     to determine if the options have already been set, and skip some or all of the
        //     logic in Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder).
        //     See DbContext lifetime, configuration, and initialization for more information
        //     and examples.
        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                // for SQL Server
                // $$$ optionsBuilder.UseSqlServer(Server=(localdb)\mssqllocaldb;Database=CarModel;Trusted_Connection=True");
                
                // For SQLite
                optionsBuilder.UseSqlite($"Data Source={DbPath}");
            }
        }

        //
        // Summary:
        //     Override this method to set defaults and configure conventions before they run.
        //     This method is invoked before Microsoft.EntityFrameworkCore.DbContext.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder).
        //
        // Parameters:
        //   configurationBuilder:
        //     The builder being used to set defaults and configure conventions that will be
        //     used to build the model for this context.
        //
        // Remarks:
        //     If a model is explicitly set on the options for this context (via Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel))
        //     then this method will not be run. However, it will still run when creating a
        //     compiled model.
        //     See Pre-convention model building in EF Core for more information and examples.
        protected  override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
        }

        //
        // Summary:
        //     Override this method to further configure the model that was discovered by convention
        //     from the entity types exposed in Microsoft.EntityFrameworkCore.DbSet`1 properties
        //     on your derived context. The resulting model may be cached and re-used for subsequent
        //     instances of your derived context.
        //
        // Parameters:
        //   modelBuilder:
        //     The builder being used to construct the model for this context. Databases (and
        //     other extensions) typically define extension methods on this object that allow
        //     you to configure aspects of the model that are specific to a given database.
        //
        // Remarks:
        //     If a model is explicitly set on the options for this context (via Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel))
        //     then this method will not be run. However, it will still run when creating a
        //     compiled model.
        //     See Modeling entity types and relationships for more information and examples.
        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
	}
}
