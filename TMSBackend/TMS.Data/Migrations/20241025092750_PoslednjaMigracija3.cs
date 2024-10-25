using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class PoslednjaMigracija3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TyreProductions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductionDate",
                value: new DateTime(2024, 10, 25, 11, 27, 49, 676, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "TyreProductions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionDate",
                value: new DateTime(2024, 10, 25, 11, 27, 49, 676, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "TyreSales",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfSale",
                value: new DateTime(2024, 10, 25, 11, 27, 49, 676, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "TyreSales",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfSale",
                value: new DateTime(2024, 10, 25, 11, 27, 49, 676, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$RJF3hcBXSEyMkJ/mp3LnZ.ImvSJUh01Nm2oqgwsTLiczy7LyJ2ZUS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$BiKdVNJupAAIxhSa3rNjuepgoW1y893mUtmEhugCP3HJD0ZZaZGQW");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$uTDCT5MVM8dNCrRx0nXEGuuIIMxHFweUuNXU2mToUMEfxqNftQGMe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TyreProductions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductionDate",
                value: new DateTime(2024, 10, 25, 11, 25, 54, 795, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "TyreProductions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionDate",
                value: new DateTime(2024, 10, 25, 11, 25, 54, 795, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "TyreSales",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfSale",
                value: new DateTime(2024, 10, 25, 11, 25, 54, 795, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "TyreSales",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfSale",
                value: new DateTime(2024, 10, 25, 11, 25, 54, 795, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$jcLQ893jdIrtP6YskZ.bKuLe5QVK3nmKeEDpufYIsL1ZNDp3hf9wG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$BLmxU4Tiz8C/DIXHE7aTXe5XZchm9YozLAO5l3UL7y7s/NBCiAUGm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$RW5TObzItuFFB57Z4.9...KekD9VPfam51prOQXWl5ilS7SwGrTaG");
        }
    }
}
