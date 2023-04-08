using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagiVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUserToDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 16, 15, 229, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 16, 15, 229, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 16, 15, 229, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 16, 15, 229, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 16, 15, 229, DateTimeKind.Local).AddTicks(7366));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 12, 28, 749, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 12, 28, 749, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 12, 28, 749, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 12, 28, 749, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 12, 28, 749, DateTimeKind.Local).AddTicks(6638));
        }
    }
}
