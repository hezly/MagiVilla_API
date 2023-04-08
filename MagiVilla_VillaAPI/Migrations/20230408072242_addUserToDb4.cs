using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagiVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUserToDb4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LocaUserS",
                table: "LocaUserS");

            migrationBuilder.RenameTable(
                name: "LocaUserS",
                newName: "LocaUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocaUsers",
                table: "LocaUsers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 22, 42, 23, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 22, 42, 23, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 22, 42, 23, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 22, 42, 23, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 22, 42, 23, DateTimeKind.Local).AddTicks(9713));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LocaUsers",
                table: "LocaUsers");

            migrationBuilder.RenameTable(
                name: "LocaUsers",
                newName: "LocaUserS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocaUserS",
                table: "LocaUserS",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 22, 1, 363, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 22, 1, 363, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 22, 1, 363, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 22, 1, 363, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 22, 1, 363, DateTimeKind.Local).AddTicks(5900));
        }
    }
}
