using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagiVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableUpdate20230331002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 52, 1, 902, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 52, 1, 902, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 52, 1, 902, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 52, 1, 902, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 52, 1, 902, DateTimeKind.Local).AddTicks(3579));
        }
    }
}
