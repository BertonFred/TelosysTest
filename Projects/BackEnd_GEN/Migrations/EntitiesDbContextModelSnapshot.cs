﻿// <auto-generated />
using CarModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace wsRestTest.Migrations
{
    [DbContext(typeof(EntitiesDbContext))]
    partial class EntitiesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("CarModel.Entities.Comment", b =>
                {
                    b.Property<long>("oid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Post_oid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("comment")
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
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("oid");

                    b.ToTable("Posts");
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
