﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Student.Models;
using System;

namespace Student.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Student.Models.Standard", b =>
                {
                    b.Property<int>("StandardId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("StandardName");

                    b.HasKey("StandardId");

                    b.ToTable("Standard");
                });

            modelBuilder.Entity("Student.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("StandardId");

                    b.Property<int?>("StandardId1");

                    b.Property<string>("StudentName")
                        .IsRequired();

                    b.HasKey("StudentId");

                    b.HasIndex("StandardId");

                    b.HasIndex("StandardId1");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Student.Models.Student", b =>
                {
                    b.HasOne("Student.Models.Standard")
                        .WithMany("Students")
                        .HasForeignKey("StandardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Student.Models.Standard", "Standard")
                        .WithMany()
                        .HasForeignKey("StandardId1");
                });
#pragma warning restore 612, 618
        }
    }
}
