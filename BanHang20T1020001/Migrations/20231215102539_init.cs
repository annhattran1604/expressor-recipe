using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BanHang20T1020001.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    MaNCC = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    TenNCC = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SoDT = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    maloai = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    tenloai = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ngaynhap = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.maloai);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    MaDoUong = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    TenDoUong = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Gia = table.Column<long>(type: "INTEGER", nullable: false),
                    SoLuong = table.Column<long>(type: "INTEGER", nullable: false),
                    NgaySX = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NgayHH = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HinhAnh = table.Column<string>(type: "TEXT", nullable: false),
                    MaLoai = table.Column<string>(type: "TEXT", nullable: false),
                    MaNCC = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.MaDoUong);
                    table.ForeignKey(
                        name: "FK_Drinks_Provider_MaNCC",
                        column: x => x.MaNCC,
                        principalTable: "Provider",
                        principalColumn: "MaNCC",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Drinks_Type_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "Type",
                        principalColumn: "maloai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Provider",
                columns: new[] { "MaNCC", "DiaChi", "SoDT", "TenNCC" },
                values: new object[,]
                {
                    { "ncc1", "Đà Nẵng", "0123456789", "TNHH URC Việt Nam" },
                    { "ncc2", "Huế", "0374628101", "TNHH Bia Huế" }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "maloai", "ngaynhap", "tenloai" },
                values: new object[] { "tra", new DateTime(2023, 12, 15, 17, 25, 39, 98, DateTimeKind.Local).AddTicks(7308), "Trà đống chai" });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "MaDoUong", "Gia", "HinhAnh", "MaLoai", "MaNCC", "NgayHH", "NgaySX", "SoLuong", "TenDoUong" },
                values: new object[] { "1", 10000L, "image_path.jpg", "tra", "ncc1", new DateTime(2024, 1, 14, 17, 25, 39, 98, DateTimeKind.Local).AddTicks(7331), new DateTime(2023, 12, 15, 17, 25, 39, 98, DateTimeKind.Local).AddTicks(7331), 50L, "Trà C2 Hương Chanh" });

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_MaLoai",
                table: "Drinks",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_MaNCC",
                table: "Drinks",
                column: "MaNCC");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DropTable(
                name: "Type");
        }
    }
}
