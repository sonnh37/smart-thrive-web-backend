﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SWD.SmartThrive.Repositories.Data;

#nullable disable

namespace SWD.SmartThrive.Repositories.Migrations
{
    [DbContext(typeof(STDbContext))]
    partial class STDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CategorytName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid?>("Code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LocationId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("ProviderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("Sold_product")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("SubjectId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("TotalSlot")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("ProviderId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.CourseXPackage", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PackageId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CourseId", "PackageId");

                    b.HasIndex("PackageId");

                    b.ToTable("CoursePackage", (string)null);
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ward")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Location", (string)null);
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PackageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<decimal?>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Package", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("PackageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuantityCourse")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Package", (string)null);
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Provider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Provider", (string)null);
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Session", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LearnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Session", (string)null);
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid?>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("Subject", (string)null);
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LocationID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationID");

                    b.HasIndex("RoleID");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Course", b =>
                {
                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.Location", "Location")
                        .WithMany("Courses")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Location_Course");

                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.Provider", "Provider")
                        .WithMany("Courses")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("FK_Provider_Course");

                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.Subject", "Subject")
                        .WithMany("Courses")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Subject_Course");

                    b.Navigation("Location");

                    b.Navigation("Provider");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.CourseXPackage", b =>
                {
                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.Course", "Course")
                        .WithMany("CourseXPackages")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.Package", "Package")
                        .WithMany("CourseXPackages")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Package");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Order", b =>
                {
                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.Package", "Package")
                        .WithMany("Orders")
                        .HasForeignKey("PackageId")
                        .HasConstraintName("FK_Package_Order");

                    b.Navigation("Package");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Package", b =>
                {
                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.Student", "Student")
                        .WithMany("Packages")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK_Student_Packages");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Provider", b =>
                {
                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.User", "User")
                        .WithOne("Provider")
                        .HasForeignKey("SWD.SmartThrive.Repositories.Data.Table.Provider", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Session", b =>
                {
                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.Course", "Course")
                        .WithMany("Sessions")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Course_Session");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Student", b =>
                {
                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.User", "User")
                        .WithMany("Students")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_User_Student");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Subject", b =>
                {
                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.Category", "Category")
                        .WithMany("Subjects")
                        .HasForeignKey("CategoryID")
                        .HasConstraintName("FK_Category_Subject");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.User", b =>
                {
                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.Location", "Location")
                        .WithMany("Users")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_User_Location");

                    b.HasOne("SWD.SmartThrive.Repositories.Data.Table.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_User_Role");

                    b.Navigation("Location");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Category", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Course", b =>
                {
                    b.Navigation("CourseXPackages");

                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Location", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Package", b =>
                {
                    b.Navigation("CourseXPackages");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Provider", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Student", b =>
                {
                    b.Navigation("Packages");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.Subject", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("SWD.SmartThrive.Repositories.Data.Table.User", b =>
                {
                    b.Navigation("Provider");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
