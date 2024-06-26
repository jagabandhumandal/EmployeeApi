﻿// <auto-generated />
using EmployeeApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeApi.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20240313121123_initialDbCreation")]
    partial class initialDbCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeApi.Models.Employee", b =>
                {
                    b.Property<int>("empid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("empid"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("empid");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            empid = 1,
                            Name = "Action",
                            department = "HR",
                            designation = "software engineer"
                        },
                        new
                        {
                            empid = 2,
                            Name = "SciFi",
                            department = "IT",
                            designation = " engineer"
                        },
                        new
                        {
                            empid = 3,
                            Name = "History",
                            department = "Devops",
                            designation = "lead software engineer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
