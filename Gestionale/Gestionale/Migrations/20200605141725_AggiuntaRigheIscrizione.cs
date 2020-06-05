using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestionale.Migrations
{
    public partial class AggiuntaRigheIscrizione : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Iscrizioni",
                columns: new[] { "Id", "CorsiId", "DataIscrizione" },
                values: new object[] { 1, 4, new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Iscrizioni",
                columns: new[] { "Id", "CorsiId", "DataIscrizione" },
                values: new object[] { 2, 5, new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Iscrizioni",
                columns: new[] { "Id", "CorsiId", "DataIscrizione" },
                values: new object[] { 3, 1, new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Iscrizioni",
                columns: new[] { "Id", "CorsiId", "DataIscrizione" },
                values: new object[] { 4, 3, new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Iscrizioni",
                columns: new[] { "Id", "CorsiId", "DataIscrizione" },
                values: new object[] { 5, 2, new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
