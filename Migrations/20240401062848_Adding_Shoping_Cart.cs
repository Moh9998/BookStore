using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Shoping_Cart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShpingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShpingCarts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAded",
                value: new DateTime(2024, 4, 1, 9, 28, 47, 738, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAded",
                value: new DateTime(2024, 4, 1, 9, 28, 47, 738, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAded",
                value: new DateTime(2024, 4, 1, 9, 28, 47, 738, DateTimeKind.Local).AddTicks(9198));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShpingCarts");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAded",
                value: new DateTime(2024, 4, 1, 9, 27, 16, 110, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAded",
                value: new DateTime(2024, 4, 1, 9, 27, 16, 110, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAded",
                value: new DateTime(2024, 4, 1, 9, 27, 16, 110, DateTimeKind.Local).AddTicks(6836));
        }
    }
}
