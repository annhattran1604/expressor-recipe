using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BanHang20T1020001.Migrations
{
    /// <inheritdoc />
    public partial class newinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaDoUong = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    TenDoUong = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Gia = table.Column<long>(type: "INTEGER", nullable: false),
                    SoLuong = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaDoUong);
                });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "MaDoUong",
                keyValue: "1",
                columns: new[] { "NgayHH", "NgaySX" },
                values: new object[] { new DateTime(2024, 2, 3, 16, 1, 49, 294, DateTimeKind.Local).AddTicks(9220), new DateTime(2024, 1, 4, 16, 1, 49, 294, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Type",
                keyColumn: "maloai",
                keyValue: "tra",
                column: "ngaynhap",
                value: new DateTime(2024, 1, 4, 16, 1, 49, 294, DateTimeKind.Local).AddTicks(9186));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "MaDoUong",
                keyValue: "1",
                columns: new[] { "NgayHH", "NgaySX" },
                values: new object[] { new DateTime(2024, 1, 14, 17, 25, 39, 98, DateTimeKind.Local).AddTicks(7331), new DateTime(2023, 12, 15, 17, 25, 39, 98, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "Type",
                keyColumn: "maloai",
                keyValue: "tra",
                column: "ngaynhap",
                value: new DateTime(2023, 12, 15, 17, 25, 39, 98, DateTimeKind.Local).AddTicks(7308));
        }
    }
}
