using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagiVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaNumberTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VilladID",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 1, 10, 3, 12, 644, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 1, 10, 3, 12, 644, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 1, 10, 3, 12, 644, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 1, 10, 3, 12, 644, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 1, 10, 3, 12, 644, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VilladID",
                table: "VillaNumbers",
                column: "VilladID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VilladID",
                table: "VillaNumbers",
                column: "VilladID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VilladID",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VilladID",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VilladID",
                table: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 1, 8, 55, 40, 59, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 1, 8, 55, 40, 59, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 1, 8, 55, 40, 59, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 1, 8, 55, 40, 59, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 1, 8, 55, 40, 59, DateTimeKind.Local).AddTicks(952));
        }
    }
}
