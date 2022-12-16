﻿// <auto-generated />
using CarModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace wsRestTest.Migrations
{
    [DbContext(typeof(EntitiesDbContext))]
    [Migration("20221216155708_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("CarModel.Entities.Comment", b =>
                {
                    b.Property<long>("oid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Post_oid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("oid");

                    b.HasIndex("Post_oid");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CarModel.Entities.Post", b =>
                {
                    b.Property<long>("oid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("oid");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            oid = 1L,
                            Description = "Description 1",
                            Title = "Title 1"
                        },
                        new
                        {
                            oid = 2L,
                            Description = "Description 2",
                            Title = "Title 2"
                        },
                        new
                        {
                            oid = 3L,
                            Description = "Description 3",
                            Title = "Title 3"
                        },
                        new
                        {
                            oid = 4L,
                            Description = "Description 4",
                            Title = "Title 4"
                        });
                });

            modelBuilder.Entity("CarModel.Entities.Comment", b =>
                {
                    b.HasOne("CarModel.Entities.Post", "Post")
                        .WithMany()
                        .HasForeignKey("Post_oid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });
#pragma warning restore 612, 618
        }
    }
}
