using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Data_To_BookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Avalibality", "DateAded", "Genre", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", true, new DateTime(2024, 3, 31, 10, 48, 51, 585, DateTimeKind.Local).AddTicks(1775), "Fiction", 7.99m, "The Great Gatsby" },
                    { 2, "William Golding", true, new DateTime(2024, 3, 31, 10, 48, 51, 585, DateTimeKind.Local).AddTicks(1782), "Fiction", 7.99m, "Lord of the Flies" },
                    { 3, "Joydip Kanjilal", true, new DateTime(2024, 3, 31, 10, 48, 51, 585, DateTimeKind.Local).AddTicks(1788), "Programming", 7.99m, "Asp.NetCore WebApiBuild Rubust backends" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
