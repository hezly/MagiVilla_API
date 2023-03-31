using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagiVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableUpdate20230331001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 47, 38, 284, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 47, 38, 284, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 47, 38, 284, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 47, 38, 284, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 15, 47, 38, 284, DateTimeKind.Local).AddTicks(7517));
        }
    }
}
