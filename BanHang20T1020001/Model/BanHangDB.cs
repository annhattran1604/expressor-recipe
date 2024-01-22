using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BanHang20T1020001.Model
{
    public class BanHangDB : DbContext
    {
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Drinks> Drinks { get; set; }
        public DbSet<Types> Types { get; set; }

        public DbSet<HoaDon> hoaDons { get; set; }
        public string DbName = "banhang.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            String path = Path.Combine(Application.StartupPath, DbName); ;
            optionsBuilder.UseSqlite($"Data source = {path}").EnableSensitiveDataLogging();
            /*optionsbuilder.usesqlserver("connection string");*/
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var newProvider1 = new Provider
            {
                MaNCC = "ncc1",
                TenNCC = "TNHH URC Việt Nam",
                SoDT = "0123456789",
                DiaChi = "Đà Nẵng"
            };
            var newProvider2 = new Provider
            {
                MaNCC = "ncc2",
                TenNCC = "TNHH Bia Huế",
                SoDT = "0374628101",
                DiaChi = "Huế"
            };
            modelBuilder.Entity<Provider>().HasData(newProvider1,newProvider2);
            var newType = new Types
            {
                maloai = "tra",
                tenloai = "Trà đống chai",
                ngaynhap = DateTime.Now
            };
            modelBuilder.Entity<Types>().HasData(newType);
            var newDrink = new Drinks
            {
                MaDoUong = "1",
                TenDoUong = "Trà C2 Hương Chanh",
                Gia = 10000,
                SoLuong = 50,
                NgaySX = DateTime.Now,
                NgayHH = DateTime.Now.AddDays(30),
                HinhAnh = "image_path.jpg",
                MaLoai = "tra", // Replace with actual category foreign key
                MaNCC = "ncc1" // Replace with actual provider foreign key
            };
            modelBuilder.Entity<Drinks>().HasData(newDrink);
        }
    }
}
