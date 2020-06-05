using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestionale.Migrations
{
    public partial class AggiuntaRighePartecipanti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 16, 41, 41, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 16, 41, 41, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 16, 41, 41, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 16, 41, 41, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 16, 41, 41, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Partecipanti",
                columns: new[] { "Id", "AnnoDiploma", "Citta", "Cognome", "CorsiId", "DataNascita", "Diploma", "Email", "Indirizzo", "IscrizioniId", "Nome", "Telefono" },
                values: new object[] { 1, new DateTime(2010, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cesena", "Polo", 1, new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tecnico", "MarcoPolo@gmail.com", "Via Polo 29°", 3, "Marco", "3338614937" });

            migrationBuilder.InsertData(
                table: "Partecipanti",
                columns: new[] { "Id", "AnnoDiploma", "Citta", "Cognome", "CorsiId", "DataNascita", "Diploma", "Email", "Indirizzo", "IscrizioniId", "Nome", "Telefono" },
                values: new object[] { 2, new DateTime(2016, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bologna", "Venere", 2, new DateTime(1995, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sociale", "GiorgiaVenere@gmail.com", "Via Venere 219°", 5, "Giorgia", "3338895937" });

            migrationBuilder.InsertData(
                table: "Partecipanti",
                columns: new[] { "Id", "AnnoDiploma", "Citta", "Cognome", "CorsiId", "DataNascita", "Diploma", "Email", "Indirizzo", "IscrizioniId", "Nome", "Telefono" },
                values: new object[] { 3, new DateTime(2019, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rimini", "Deandrè", 3, new DateTime(2000, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tecnico", "LuigiDeandè@gmail.com", "Via Deandè 5°", 4, "Luigi", "3338678437" });

            migrationBuilder.InsertData(
                table: "Partecipanti",
                columns: new[] { "Id", "AnnoDiploma", "Citta", "Cognome", "CorsiId", "DataNascita", "Diploma", "Email", "Indirizzo", "IscrizioniId", "Nome", "Telefono" },
                values: new object[] { 4, new DateTime(2018, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forlì", "Pane", 4, new DateTime(1999, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tecnico", "MartaPane@gmail.com", "Via Pane 15°", 1, "Marta", "3458684937" });

            migrationBuilder.InsertData(
                table: "Partecipanti",
                columns: new[] { "Id", "AnnoDiploma", "Citta", "Cognome", "CorsiId", "DataNascita", "Diploma", "Email", "Indirizzo", "IscrizioniId", "Nome", "Telefono" },
                values: new object[] { 5, new DateTime(2017, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faenza", "Telo", 5, new DateTime(1998, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tecnico", "GiorgiaTelo@gmail.com", "Via Telo 78°", 2, "Giorgia", "3338614937" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Partecipanti",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Partecipanti",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Partecipanti",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Partecipanti",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Partecipanti",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified));
        }
    }
}
