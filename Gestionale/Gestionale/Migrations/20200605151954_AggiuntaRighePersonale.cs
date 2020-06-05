using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestionale.Migrations
{
    public partial class AggiuntaRighePersonale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 15, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 0, "Rosa", 5, new DateTime(1987, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "FrancescaRosa@gmail.com", "Francesca", "3258414787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 14, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 0, "Terra", 4, new DateTime(1988, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MarcoTerra@gmail.com", "Marco", "3258610787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 13, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 0, "Martin", 3, new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "SaraMartin@gmail.com", "Sara", "3258614977" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 12, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 0, "De'Martino", 2, new DateTime(1978, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlessandroDeMartino@gmail.com", "Alessandro", "3258174787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 11, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 0, "Telepatia", 1, new DateTime(1979, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "RosaliaTelepatia@gmail.com", "Rosalia", "3278614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 10, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 1, "Ortè", 5, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlessandroOrtè@gmail.com", "Alessandro", "3258614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 8, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 1, "Del Mio", 3, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "CarmineDelMio@gmail.com", "Carmine", "3278614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 7, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 1, "Frafra", 2, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "GiuliaFrafra@gmail.com", "Giulia", "3248614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 6, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 1, "Giuseppa", 1, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MauroGiuseppa@gmail.com", "Mauro", "3228614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 5, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 2, "Raro", 5, new DateTime(1980, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MattiaRaro@gmail.com", "Mattia", "3458614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 4, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 2, "Dadi", 4, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "DarioDadi@gmail.com", "Dario", "3457914787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 3, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 2, "Stella", 3, new DateTime(1987, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "GiorgiaStella@gmail.com", "Giorgia", "3458618787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 2, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 2, "Grud", 2, new DateTime(1988, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "PaolaGrud@gmail.com", "Paola", "3458775787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 9, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 1, "Del Capo", 4, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "FrancescaDelCapo@gmail.com", "Francesca", "3298614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categorie", "Cognome", "CorsiId", "DataNascita", "Email", "Nome", "Telefono" },
                values: new object[] { 1, new DateTime(2020, 6, 5, 17, 19, 54, 0, DateTimeKind.Unspecified), 2, "Frasulli", 1, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MatteoFrasulli@gmail.com", "Matteo", "3458614787" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 15);

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
        }
    }
}
