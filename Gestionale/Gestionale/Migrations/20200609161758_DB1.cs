using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestionale.Migrations
{
    public partial class DB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 10, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Tutor", "Ortè", 5, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tutor", "AlessandroOrtè@gmail.com", "Alessandro", "3258614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 9, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Tutor", "Del Capo", 4, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tutor", "FrancescaDelCapo@gmail.com", "Francesca", "3298614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 8, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Tutor", "Del Mio", 3, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tutor", "CarmineDelMio@gmail.com", "Carmine", "3278614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 7, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Tutor", "Frafra", 2, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tutor", "GiuliaFrafra@gmail.com", "Giulia", "3248614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 6, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Tutor", "Giuseppa", 1, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tutor", "MauroGiuseppa@gmail.com", "Mauro", "3228614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 15, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Insegnante", "Rosa", 5, new DateTime(1987, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insegnanti", "FrancescaRosa@gmail.com", "Francesca", "3258414787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 13, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Insegnante", "Martin", 3, new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insegnanti", "SaraMartin@gmail.com", "Sara", "3258614977" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 12, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Insegnante", "De'Martino", 2, new DateTime(1979, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insegnanti", "AlessandroDeMartino@gmail.com", "Alessandro", "3258174787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 11, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Insegnante", "Telepatia", 1, new DateTime(1979, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insegnanti", "RosaliaTelepatia@gmail.com", "Rosalia", "3278614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 5, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Coordinatore", "Raro", 5, new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coordinatore", "MattiaRaro@gmail.com", "Mattia", "3458614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 4, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Coordinatore", "Dadi", 4, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coordinatore", "DarioDadi@gmail.com", "Dario", "3457914787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 3, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Coordinatore", "Stella", 3, new DateTime(1987, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coordinatore", "GiorgiaStella@gmail.com", "Giorgia", "3458618787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 2, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Coordinatore", "Grud", 2, new DateTime(1988, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coordinatore", "PaolaGrud@gmail.com", "Paola", "3458775787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 14, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Insegnante", "Terra", 4, new DateTime(1988, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insegnanti", "MarcoTerra@gmail.com", "Marco", "3258610787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 1, new DateTime(2020, 6, 9, 18, 17, 57, 0, DateTimeKind.Unspecified), "Coordinatore", "Frasulli", 1, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coordinatore", "MatteoFrasulli@gmail.com", "Matteo", "3458614787" });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CorsiId", "DataFine", "DataInizio", "Materia", "PersonaleId" },
                values: new object[] { 2, 2, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C#", 1 });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CorsiId", "DataFine", "DataInizio", "Materia", "PersonaleId" },
                values: new object[] { 3, 3, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inglese", 5 });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CorsiId", "DataFine", "DataInizio", "Materia", "PersonaleId" },
                values: new object[] { 1, 1, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programmazione OOP", 11 });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CorsiId", "DataFine", "DataInizio", "Materia", "PersonaleId" },
                values: new object[] { 4, 4, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lavorare in team", 12 });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CorsiId", "DataFine", "DataInizio", "Materia", "PersonaleId" },
                values: new object[] { 5, 5, new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Relazione con il Cliente", 15 });

            migrationBuilder.InsertData(
                table: "Esami",
                columns: new[] { "Id", "DataEsame", "ModuliId" },
                values: new object[] { 4, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Esami",
                columns: new[] { "Id", "DataEsame", "ModuliId" },
                values: new object[] { 3, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Esami",
                columns: new[] { "Id", "DataEsame", "ModuliId" },
                values: new object[] { 5, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Esami",
                columns: new[] { "Id", "DataEsame", "ModuliId" },
                values: new object[] { 2, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Esami",
                columns: new[] { "Id", "DataEsame", "ModuliId" },
                values: new object[] { 1, new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });
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
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 14);

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
                table: "Moduli",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Personale",
                keyColumn: "Id",
                keyValue: 5);

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
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 9, 17, 40, 55, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 9, 17, 40, 55, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 9, 17, 40, 55, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 9, 17, 40, 55, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Iscrizioni",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIscrizione",
                value: new DateTime(2020, 6, 9, 17, 40, 55, 0, DateTimeKind.Unspecified));
        }
    }
}
