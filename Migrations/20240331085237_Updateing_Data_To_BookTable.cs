using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class Updateing_Data_To_BookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BooksInStock",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BooksInStock", "DateAded" },
                values: new object[] { 0, new DateTime(2024, 3, 31, 11, 52, 36, 258, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BooksInStock", "DateAded" },
                values: new object[] { 0, new DateTime(2024, 3, 31, 11, 52, 36, 258, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BooksInStock", "DateAded" },
                values: new object[] { 0, new DateTime(2024, 3, 31, 11, 52, 36, 258, DateTimeKind.Local).AddTicks(6370) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BooksInStock",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAded",
                value: new DateTime(2024, 3, 31, 10, 48, 51, 585, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAded",
                value: new DateTime(2024, 3, 31, 10, 48, 51, 585, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAded",
                value: new DateTime(2024, 3, 31, 10, 48, 51, 585, DateTimeKind.Local).AddTicks(1788));
        }
    }
}
