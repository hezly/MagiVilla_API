using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagiVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableUpdate20230331003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 54, 51, 300, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 54, 51, 300, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 54, 51, 300, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 54, 51, 300, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 54, 51, 300, DateTimeKind.Local).AddTicks(2027));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 52, 58, 161, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 52, 58, 161, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 52, 58, 161, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 52, 58, 161, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 52, 58, 161, DateTimeKind.Local).AddTicks(5433));
        }
    }
}
