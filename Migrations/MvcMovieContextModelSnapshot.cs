﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreDemo.Data;

namespace NetCoreDemo.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("NetCoreDemo.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("NetCoreDemo.Models.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("KhachHangId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KhachHangId");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("NetCoreDemo.Models.KhachHang", b =>
                {
                    b.Property<int>("KhachHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenKhachHang")
                        .HasColumnType("TEXT");

                    b.HasKey("KhachHangId");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("NetCoreDemo.Models.LuongBong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("NhanVienId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("NhanVienId");

                    b.ToTable("LuongBong");
                });

            modelBuilder.Entity("NetCoreDemo.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("NetCoreDemo.Models.NhanVien", b =>
                {
                    b.Property<int>("NhanVienId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenNhanVien")
                        .HasColumnType("TEXT");

                    b.HasKey("NhanVienId");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("NetCoreDemo.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonCode")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("NetCoreDemo.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("NetCoreDemo.Models.SinhVien", b =>
                {
                    b.Property<string>("SinhVienID")
                        .HasColumnType("TEXT");

                    b.Property<string>("HoTen")
                        .HasColumnType("TEXT");

                    b.HasKey("SinhVienID");

                    b.ToTable("SinhViens");
                });

            modelBuilder.Entity("NetCoreDemo.Models.Student", b =>
                {
                    b.HasBaseType("NetCoreDemo.Models.Person");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Universisty")
                        .HasColumnType("TEXT");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("NetCoreDemo.Models.Teacher", b =>
                {
                    b.HasBaseType("NetCoreDemo.Models.Person");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Universisty")
                        .HasColumnType("TEXT");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("NetCoreDemo.Models.HoaDon", b =>
                {
                    b.HasOne("NetCoreDemo.Models.KhachHang", "khachHangs")
                        .WithMany("hoadons")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("khachHangs");
                });

            modelBuilder.Entity("NetCoreDemo.Models.LuongBong", b =>
                {
                    b.HasOne("NetCoreDemo.Models.NhanVien", "NhanViens")
                        .WithMany("LuongBongs")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("NetCoreDemo.Models.Student", b =>
                {
                    b.HasOne("NetCoreDemo.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("NetCoreDemo.Models.Student", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NetCoreDemo.Models.Teacher", b =>
                {
                    b.HasOne("NetCoreDemo.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("NetCoreDemo.Models.Teacher", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NetCoreDemo.Models.KhachHang", b =>
                {
                    b.Navigation("hoadons");
                });

            modelBuilder.Entity("NetCoreDemo.Models.NhanVien", b =>
                {
                    b.Navigation("LuongBongs");
                });
#pragma warning restore 612, 618
        }
    }
}
