﻿// <auto-generated />
using System;
using DotNetRecipesApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNetRecipeApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230303054018_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("DotNetRecipesApp.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Karma")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("DotNetRecipesApp.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CookingInstructions")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DownVotes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UpVotes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserRatings")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("DotNetRecipesApp.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHealthConscience")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("DotNetRecipesApp.Entities.Tag", b =>
                {
                    b.HasOne("DotNetRecipesApp.Entities.Recipe", null)
                        .WithMany("Tags")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("DotNetRecipesApp.Entities.Recipe", b =>
                {
                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
