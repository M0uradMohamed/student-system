﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSystem.Data;

#nullable disable

namespace StudentSystem.Migrations
{
    [DbContext(typeof(StudentSystemContext))]
    [Migration("20240921140340_fix_database4")]
    partial class fix_database4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentSystem.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Description")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(80)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Description = "back end programing",
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(101),
                            Name = ".net",
                            Price = 5000.0,
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(11)
                        },
                        new
                        {
                            CourseId = 2,
                            Description = "front end programing",
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(202),
                            Name = "ux ui",
                            Price = 4500.0,
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(20)
                        },
                        new
                        {
                            CourseId = 3,
                            Description = "basic programing",
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(31),
                            Name = "intro",
                            Price = 1500.0,
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(12)
                        });
                });

            modelBuilder.Entity("StudentSystem.Models.Homework", b =>
                {
                    b.Property<int>("HomeworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomeworkId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("ContentType")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmissionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("HomeworkId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Homework");

                    b.HasData(
                        new
                        {
                            HomeworkId = 1,
                            Content = "problem solving",
                            ContentType = 1,
                            CourseId = 3,
                            StudentId = 2,
                            SubmissionTime = new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            HomeworkId = 2,
                            Content = "ef core",
                            ContentType = 2,
                            CourseId = 2,
                            StudentId = 3,
                            SubmissionTime = new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            HomeworkId = 3,
                            Content = "designing",
                            ContentType = 3,
                            CourseId = 2,
                            StudentId = 1,
                            SubmissionTime = new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            HomeworkId = 4,
                            Content = "oop",
                            ContentType = 1,
                            CourseId = 1,
                            StudentId = 2,
                            SubmissionTime = new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("StudentSystem.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ResourceType")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("ResourceId");

                    b.HasIndex("CourseId");

                    b.ToTable("Resource");

                    b.HasData(
                        new
                        {
                            ResourceId = 1,
                            CourseId = 1,
                            Name = "jonny",
                            ResourceType = 1,
                            Url = "www.eraasoft.com"
                        },
                        new
                        {
                            ResourceId = 2,
                            CourseId = 3,
                            Name = "tom",
                            ResourceType = 3,
                            Url = "www.microsoft.com"
                        },
                        new
                        {
                            ResourceId = 3,
                            CourseId = 3,
                            Name = "sam",
                            ResourceType = 2,
                            Url = "www.amazon.com"
                        },
                        new
                        {
                            ResourceId = 4,
                            CourseId = 2,
                            Name = "keano",
                            ResourceType = 4,
                            Url = "www.steam.com"
                        });
                });

            modelBuilder.Entity("StudentSystem.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentId");

                    b.ToTable("Student", t =>
                        {
                            t.HasCheckConstraint("ch_phoneNumberLength", "LEN(PhoneNumber) = 10");
                        });

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Birthday = new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ahmed mohamed",
                            PhoneNumber = "0236789066",
                            RegisteredOn = new DateTime(2024, 9, 21, 17, 3, 39, 734, DateTimeKind.Local).AddTicks(8456)
                        },
                        new
                        {
                            StudentId = 2,
                            Birthday = new DateTime(1999, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "moahmed abdo",
                            PhoneNumber = "1705454135",
                            RegisteredOn = new DateTime(2024, 9, 21, 17, 3, 39, 734, DateTimeKind.Local).AddTicks(8508)
                        },
                        new
                        {
                            StudentId = 3,
                            Birthday = new DateTime(1998, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "mohsen ali",
                            PhoneNumber = "1210648789",
                            RegisteredOn = new DateTime(2024, 9, 21, 17, 3, 39, 734, DateTimeKind.Local).AddTicks(8513)
                        });
                });

            modelBuilder.Entity("StudentSystem.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourse");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 2
                        },
                        new
                        {
                            StudentId = 1,
                            CourseId = 3
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 3
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 2
                        });
                });

            modelBuilder.Entity("StudentSystem.Models.Homework", b =>
                {
                    b.HasOne("StudentSystem.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Models.Student", "Student")
                        .WithMany("Homeworks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.Models.Resource", b =>
                {
                    b.HasOne("StudentSystem.Models.Course", "Course")
                        .WithMany("Resources")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentSystem.Models.StudentCourse", b =>
                {
                    b.HasOne("StudentSystem.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentSystem.Models.Course", b =>
                {
                    b.Navigation("Resources");
                });

            modelBuilder.Entity("StudentSystem.Models.Student", b =>
                {
                    b.Navigation("Homeworks");
                });
#pragma warning restore 612, 618
        }
    }
}
