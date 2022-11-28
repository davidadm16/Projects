﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpaceSystemDB;

#nullable disable

namespace SpaceSystemDB.Migrations
{
    [DbContext(typeof(SpaceSystemDBContext))]
    [Migration("20221121230822_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SpaceSystemModels.PeopleModels.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SpaceSystemModels.PeopleModels.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@rentastar.com",
                            FirstName = "David",
                            LastName = "Diaz",
                            Password = "Password",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("SpaceSystemModels.SpaceBodyModels.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BoughtId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<decimal?>("GravitationalPull")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<int?>("Moons")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrbitInDays")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Planets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BoughtId = 0,
                            GravitationalPull = 3.7m,
                            Moons = 0,
                            Name = "Mercury",
                            OrbitInDays = 88
                        },
                        new
                        {
                            Id = 2,
                            BoughtId = 0,
                            GravitationalPull = 8.9m,
                            Moons = 0,
                            Name = "Venus",
                            OrbitInDays = 225
                        },
                        new
                        {
                            Id = 3,
                            BoughtId = 0,
                            GravitationalPull = 9.8m,
                            Moons = 1,
                            Name = "Earth",
                            OrbitInDays = 365
                        },
                        new
                        {
                            Id = 4,
                            BoughtId = 0,
                            GravitationalPull = 3.7m,
                            Moons = 2,
                            Name = "Mars",
                            OrbitInDays = 687
                        },
                        new
                        {
                            Id = 5,
                            BoughtId = 0,
                            GravitationalPull = 23.1m,
                            Moons = 57,
                            Name = "Jupiter",
                            OrbitInDays = 4333
                        },
                        new
                        {
                            Id = 6,
                            BoughtId = 0,
                            GravitationalPull = 9.0m,
                            Moons = 63,
                            Name = "Saturn",
                            OrbitInDays = 10759
                        },
                        new
                        {
                            Id = 7,
                            BoughtId = 0,
                            GravitationalPull = 8.7m,
                            Moons = 27,
                            Name = "Uranus",
                            OrbitInDays = 30687
                        },
                        new
                        {
                            Id = 8,
                            BoughtId = 0,
                            GravitationalPull = 11.0m,
                            Moons = 14,
                            Name = "Neptune",
                            OrbitInDays = 60190
                        });
                });

            modelBuilder.Entity("SpaceSystemModels.SpaceBodyModels.Star", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BoughtId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Brightness")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Temperature")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Stars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BoughtId = 0,
                            Brightness = -26.74m,
                            Name = "Sun",
                            Temperature = 1
                        });
                });

            modelBuilder.Entity("SpaceSystemModels.SpaceBodyModels.Planet", b =>
                {
                    b.HasOne("SpaceSystemModels.PeopleModels.Customer", "Customer")
                        .WithMany("Planets")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("SpaceSystemModels.SpaceBodyModels.Star", b =>
                {
                    b.HasOne("SpaceSystemModels.PeopleModels.Customer", "Customer")
                        .WithMany("Stars")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("SpaceSystemModels.PeopleModels.Customer", b =>
                {
                    b.Navigation("Planets");

                    b.Navigation("Stars");
                });
#pragma warning restore 612, 618
        }
    }
}