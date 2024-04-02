using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Shopping_Cart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogEvent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogHost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogReferrer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogResponse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogSession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogServer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientIp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientDevice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientOs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientBrowser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientTimezone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientReferrer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientResponse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientSession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientServer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientHost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientQuery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientFragment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientProtocol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientScheme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientAuthority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogClientHostIp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.LogId);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BooksInStock", "CartId", "DateAded" },
                values: new object[] { 10, null, new DateTime(2024, 4, 2, 10, 29, 50, 257, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BooksInStock", "CartId", "DateAded" },
                values: new object[] { 10, null, new DateTime(2024, 4, 2, 10, 29, 50, 257, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BooksInStock", "CartId", "DateAded" },
                values: new object[] { 10, null, new DateTime(2024, 4, 2, 10, 29, 50, 257, DateTimeKind.Local).AddTicks(2679) });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CartId",
                table: "Books",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Carts_CartId",
                table: "Books",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Carts_CartId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Books_CartId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BooksInStock", "DateAded" },
                values: new object[] { 0, new DateTime(2024, 4, 1, 10, 56, 36, 763, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BooksInStock", "DateAded" },
                values: new object[] { 0, new DateTime(2024, 4, 1, 10, 56, 36, 763, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BooksInStock", "DateAded" },
                values: new object[] { 0, new DateTime(2024, 4, 1, 10, 56, 36, 763, DateTimeKind.Local).AddTicks(4451) });
        }
    }
}
