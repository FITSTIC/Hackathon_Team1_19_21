using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestionale.Migrations
{
    public partial class aggiuntaRigheModili : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Moduli",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonaleId",
                value: 11);

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CorsiId", "DataFine", "DataInizio", "Materia", "PersonaleId" },
                values: new object[] { 2, 2, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C#", 1 });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CorsiId", "DataFine", "DataInizio", "Materia", "PersonaleId" },
                values: new object[] { 3, 3, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inglese", 5 });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CorsiId", "DataFine", "DataInizio", "Materia", "PersonaleId" },
                values: new object[] { 4, 4, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lavorare in team", 12 });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CorsiId", "DataFine", "DataInizio", "Materia", "PersonaleId" },
                values: new object[] { 5, 5, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Relazione con il Cliente", 15 });

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 1,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 2,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 3,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 4,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 5,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 6,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 7,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 8,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 9,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 10,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 11,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 12,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 13,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 14,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 15,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 43, 33, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Moduli",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Moduli",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Moduli",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Moduli",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Moduli",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonaleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 1,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 2,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 3,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 4,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 5,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 6,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 7,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 8,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 9,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 10,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 11,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 12,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 13,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 14,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 15,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified));
        }
    }
}
