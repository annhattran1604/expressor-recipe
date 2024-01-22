﻿// <auto-generated />
using System;
using BanHang20T1020001.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BanHang20T1020001.Migrations
{
    [DbContext(typeof(BanHangDB))]
    partial class BanHangDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("BanHang20T1020001.Model.Drinks", b =>
                {
                    b.Property<string>("MaDoUong")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<long>("Gia")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaLoai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaNCC")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgayHH")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgaySX")
                        .HasColumnType("TEXT");

                    b.Property<long>("SoLuong")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenDoUong")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("MaDoUong");

                    b.HasIndex("MaLoai");

                    b.HasIndex("MaNCC");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            MaDoUong = "1",
                            Gia = 10000L,
                            HinhAnh = "image_path.jpg",
                            MaLoai = "tra",
                            MaNCC = "ncc1",
                            NgayHH = new DateTime(2024, 2, 3, 16, 1, 49, 294, DateTimeKind.Local).AddTicks(9220),
                            NgaySX = new DateTime(2024, 1, 4, 16, 1, 49, 294, DateTimeKind.Local).AddTicks(9220),
                            SoLuong = 50L,
                            TenDoUong = "Trà C2 Hương Chanh"
                        });
                });

            modelBuilder.Entity("BanHang20T1020001.Model.HoaDon", b =>
                {
                    b.Property<string>("MaDoUong")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<long>("Gia")
                        .HasColumnType("INTEGER");

                    b.Property<long>("SoLuong")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenDoUong")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("MaDoUong");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("BanHang20T1020001.Model.Provider", b =>
                {
                    b.Property<string>("MaNCC")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SoDT")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNCC")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("MaNCC");

                    b.ToTable("Provider");

                    b.HasData(
                        new
                        {
                            MaNCC = "ncc1",
                            DiaChi = "Đà Nẵng",
                            SoDT = "0123456789",
                            TenNCC = "TNHH URC Việt Nam"
                        },
                        new
                        {
                            MaNCC = "ncc2",
                            DiaChi = "Huế",
                            SoDT = "0374628101",
                            TenNCC = "TNHH Bia Huế"
                        });
                });

            modelBuilder.Entity("BanHang20T1020001.Model.Types", b =>
                {
                    b.Property<string>("maloai")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ngaynhap")
                        .HasColumnType("TEXT");

                    b.Property<string>("tenloai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("maloai");

                    b.ToTable("Type");

                    b.HasData(
                        new
                        {
                            maloai = "tra",
                            ngaynhap = new DateTime(2024, 1, 4, 16, 1, 49, 294, DateTimeKind.Local).AddTicks(9186),
                            tenloai = "Trà đống chai"
                        });
                });

            modelBuilder.Entity("BanHang20T1020001.Model.Drinks", b =>
                {
                    b.HasOne("BanHang20T1020001.Model.Types", "Type")
                        .WithMany("Drinks")
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BanHang20T1020001.Model.Provider", "Provider")
                        .WithMany("Drinks")
                        .HasForeignKey("MaNCC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("BanHang20T1020001.Model.Provider", b =>
                {
                    b.Navigation("Drinks");
                });

            modelBuilder.Entity("BanHang20T1020001.Model.Types", b =>
                {
                    b.Navigation("Drinks");
                });
#pragma warning restore 612, 618
        }
    }
}
