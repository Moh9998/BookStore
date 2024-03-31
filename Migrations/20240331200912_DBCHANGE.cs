using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class DBCHANGE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAded",
                value: new DateTime(2024, 3, 31, 23, 9, 11, 798, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAded",
                value: new DateTime(2024, 3, 31, 23, 9, 11, 798, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAded",
                value: new DateTime(2024, 3, 31, 23, 9, 11, 798, DateTimeKind.Local).AddTicks(3467));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAded",
                value: new DateTime(2024, 3, 31, 11, 52, 36, 258, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAded",
                value: new DateTime(2024, 3, 31, 11, 52, 36, 258, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAded",
                value: new DateTime(2024, 3, 31, 11, 52, 36, 258, DateTimeKind.Local).AddTicks(6370));
        }
    }
}
