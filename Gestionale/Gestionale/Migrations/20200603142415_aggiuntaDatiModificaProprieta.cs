using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestionale.Migrations
{
    public partial class aggiuntaDatiModificaProprieta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Corsi",
                columns: new[] { "Id", "AnnoAccademico", "AnnoFineCorso", "AnnoInizioCorso", "Nome", "Sede" },
                values: new object[] { 1, "21/23", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turing", "Bologna" });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CorsiId", "DataFine", "DataInizio", "Materia", "PersonaleId" },
                values: new object[] { 1, null, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programmazione OOP", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Corsi",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Moduli",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
