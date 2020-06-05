using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestionale.Migrations
{
    public partial class AggiuntaRigheCorsi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Corsi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Nome", "Sede" },
                values: new object[] { "Alan Turing", "Cesena" });

            migrationBuilder.InsertData(
                table: "Corsi",
                columns: new[] { "Id", "AnnoAccademico", "AnnoFineCorso", "AnnoInizioCorso", "Nome", "Sede" },
                values: new object[] { 2, "21/23", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marshall McLuhan", "Bologna" });

            migrationBuilder.InsertData(
                table: "Corsi",
                columns: new[] { "Id", "AnnoAccademico", "AnnoFineCorso", "AnnoInizioCorso", "Nome", "Sede" },
                values: new object[] { 3, "21/23", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace Hopper", "Modena" });

            migrationBuilder.InsertData(
                table: "Corsi",
                columns: new[] { "Id", "AnnoAccademico", "AnnoFineCorso", "AnnoInizioCorso", "Nome", "Sede" },
                values: new object[] { 4, "21/23", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product Manager Fashion", "Carpi" });

            migrationBuilder.InsertData(
                table: "Corsi",
                columns: new[] { "Id", "AnnoAccademico", "AnnoFineCorso", "AnnoInizioCorso", "Nome", "Sede" },
                values: new object[] { 5, "21/23", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expert Mixed Reality", "Casalecchio" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Corsi",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Corsi",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Corsi",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Corsi",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Corsi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Nome", "Sede" },
                values: new object[] { "Turing", "Bologna" });
        }
    }
}
