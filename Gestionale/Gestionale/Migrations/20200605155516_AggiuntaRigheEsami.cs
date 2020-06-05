using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestionale.Migrations
{
    public partial class AggiuntaRigheEsami : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Esami",
                columns: new[] { "Id", "DataEsame", "ModuliId", "Punteggio" },
                values: new object[] { 1, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null });

            migrationBuilder.InsertData(
                table: "Esami",
                columns: new[] { "Id", "DataEsame", "ModuliId", "Punteggio" },
                values: new object[] { 2, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null });

            migrationBuilder.InsertData(
                table: "Esami",
                columns: new[] { "Id", "DataEsame", "ModuliId", "Punteggio" },
                values: new object[] { 3, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null });

            migrationBuilder.InsertData(
                table: "Esami",
                columns: new[] { "Id", "DataEsame", "ModuliId", "Punteggio" },
                values: new object[] { 4, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null });

            migrationBuilder.InsertData(
                table: "Esami",
                columns: new[] { "Id", "DataEsame", "ModuliId", "Punteggio" },
                values: new object[] { 5, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null });

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 1,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 2,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 3,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 4,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 5,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 6,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 7,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 8,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 9,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 10,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 11,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 12,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 13,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 14,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 15,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 55, 15, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Esami",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Esami",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Esami",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Esami",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Esami",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 1,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 2,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 3,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 4,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 5,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 6,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 7,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 8,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 9,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 10,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 11,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 12,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 13,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 14,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 15,
                column: "Assunzione",
                value: new DateTime(2020, 6, 5, 17, 50, 3, 0, DateTimeKind.Unspecified));
        }
    }
}
