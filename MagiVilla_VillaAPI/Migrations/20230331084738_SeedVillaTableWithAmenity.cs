using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagiVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableWithAmenity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "-", new DateTime(2023, 3, 31, 15, 47, 38, 284, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "-", new DateTime(2023, 3, 31, 15, 47, 38, 284, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "-", new DateTime(2023, 3, 31, 15, 47, 38, 284, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "-", new DateTime(2023, 3, 31, 15, 47, 38, 284, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "-", new DateTime(2023, 3, 31, 15, 47, 38, 284, DateTimeKind.Local).AddTicks(7517) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "", new DateTime(2023, 3, 31, 15, 43, 49, 739, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "", new DateTime(2023, 3, 31, 15, 43, 49, 739, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "", new DateTime(2023, 3, 31, 15, 43, 49, 739, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "", new DateTime(2023, 3, 31, 15, 43, 49, 739, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "", new DateTime(2023, 3, 31, 15, 43, 49, 739, DateTimeKind.Local).AddTicks(4042) });
        }
    }
}
