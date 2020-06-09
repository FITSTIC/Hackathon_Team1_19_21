using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestionale.Migrations
{
    public partial class modificadbmodili : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Corsi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    AnnoAccademico = table.Column<string>(nullable: false),
                    AnnoInizioCorso = table.Column<DateTime>(nullable: false),
                    AnnoFineCorso = table.Column<DateTime>(nullable: false),
                    Sede = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corsi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Iscrizioni",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataIscrizione = table.Column<DateTime>(nullable: false),
                    CorsiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iscrizioni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Iscrizioni_Corsi_CorsiId",
                        column: x => x.CorsiId,
                        principalTable: "Corsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Cognome = table.Column<string>(nullable: false),
                    DataNascita = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: false),
                    Assunzione = table.Column<DateTime>(nullable: false),
                    Categoria = table.Column<string>(nullable: true),
                    CorsiId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personale_Corsi_CorsiId",
                        column: x => x.CorsiId,
                        principalTable: "Corsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moduli",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Materia = table.Column<string>(nullable: false),
                    CorsiId = table.Column<int>(nullable: false),
                    DataInizio = table.Column<DateTime>(nullable: false),
                    DataFine = table.Column<DateTime>(nullable: false),
                    InsegnanteId = table.Column<int>(nullable: true),
                    InsegnantiId = table.Column<int>(nullable: true),
                    TutorId = table.Column<int>(nullable: true),
                    CoordinatoreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moduli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moduli_Personale_CoordinatoreId",
                        column: x => x.CoordinatoreId,
                        principalTable: "Personale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Moduli_Corsi_CorsiId",
                        column: x => x.CorsiId,
                        principalTable: "Corsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Moduli_Personale_InsegnantiId",
                        column: x => x.InsegnantiId,
                        principalTable: "Personale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Moduli_Personale_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Personale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Esami",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ModuliId = table.Column<int>(nullable: false),
                    DataEsame = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Esami", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Esami_Moduli_ModuliId",
                        column: x => x.ModuliId,
                        principalTable: "Moduli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Partecipanti",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Cognome = table.Column<string>(nullable: false),
                    DataNascita = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Indirizzo = table.Column<string>(nullable: false),
                    Citta = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false),
                    Diploma = table.Column<string>(nullable: true),
                    AnnoDiploma = table.Column<DateTime>(nullable: false),
                    IscrizioniId = table.Column<int>(nullable: false),
                    CorsiId = table.Column<int>(nullable: false),
                    EsamiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partecipanti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partecipanti_Corsi_CorsiId",
                        column: x => x.CorsiId,
                        principalTable: "Corsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Partecipanti_Esami_EsamiId",
                        column: x => x.EsamiId,
                        principalTable: "Esami",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partecipanti_Iscrizioni_IscrizioniId",
                        column: x => x.IscrizioniId,
                        principalTable: "Iscrizioni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Corsi",
                columns: new[] { "Id", "AnnoAccademico", "AnnoFineCorso", "AnnoInizioCorso", "Nome", "Sede" },
                values: new object[] { 1, "21/23", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alan Turing", "Cesena" });

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

            migrationBuilder.InsertData(
                table: "Iscrizioni",
                columns: new[] { "Id", "CorsiId", "DataIscrizione" },
                values: new object[] { 3, 1, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Iscrizioni",
                columns: new[] { "Id", "CorsiId", "DataIscrizione" },
                values: new object[] { 1, 4, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Iscrizioni",
                columns: new[] { "Id", "CorsiId", "DataIscrizione" },
                values: new object[] { 5, 2, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Iscrizioni",
                columns: new[] { "Id", "CorsiId", "DataIscrizione" },
                values: new object[] { 2, 5, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Iscrizioni",
                columns: new[] { "Id", "CorsiId", "DataIscrizione" },
                values: new object[] { 4, 3, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 1, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Coordinatore", "Frasulli", 1, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coordinatore", "MatteoFrasulli@gmail.com", "Matteo", "3458614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 15, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Insegnante", "Rosa", 5, new DateTime(1987, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insegnanti", "FrancescaRosa@gmail.com", "Francesca", "3258414787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 5, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Coordinatore", "Raro", 5, new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coordinatore", "MattiaRaro@gmail.com", "Mattia", "3458614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 9, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Tutor", "Del Capo", 4, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tutor", "FrancescaDelCapo@gmail.com", "Francesca", "3298614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 14, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Insegnante", "Terra", 4, new DateTime(1988, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insegnanti", "MarcoTerra@gmail.com", "Marco", "3258610787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 4, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Coordinatore", "Dadi", 4, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coordinatore", "DarioDadi@gmail.com", "Dario", "3457914787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 13, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Insegnante", "Martin", 3, new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insegnanti", "SaraMartin@gmail.com", "Sara", "3258614977" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 3, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Coordinatore", "Stella", 3, new DateTime(1987, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coordinatore", "GiorgiaStella@gmail.com", "Giorgia", "3458618787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 7, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Tutor", "Frafra", 2, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tutor", "GiuliaFrafra@gmail.com", "Giulia", "3248614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 12, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Insegnante", "De'Martino", 2, new DateTime(1979, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insegnanti", "AlessandroDeMartino@gmail.com", "Alessandro", "3258174787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 2, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Coordinatore", "Grud", 2, new DateTime(1988, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coordinatore", "PaolaGrud@gmail.com", "Paola", "3458775787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 6, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Tutor", "Giuseppa", 1, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tutor", "MauroGiuseppa@gmail.com", "Mauro", "3228614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 11, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Insegnante", "Telepatia", 1, new DateTime(1979, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insegnanti", "RosaliaTelepatia@gmail.com", "Rosalia", "3278614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 8, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Tutor", "Del Mio", 3, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tutor", "CarmineDelMio@gmail.com", "Carmine", "3278614787" });

            migrationBuilder.InsertData(
                table: "Personale",
                columns: new[] { "Id", "Assunzione", "Categoria", "Cognome", "CorsiId", "DataNascita", "Discriminator", "Email", "Nome", "Telefono" },
                values: new object[] { 10, new DateTime(2020, 6, 9, 22, 46, 27, 0, DateTimeKind.Unspecified), "Tutor", "Ortè", 5, new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tutor", "AlessandroOrtè@gmail.com", "Alessandro", "3258614787" });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CoordinatoreId", "CorsiId", "DataFine", "DataInizio", "InsegnanteId", "InsegnantiId", "Materia", "TutorId" },
                values: new object[] { 5, null, 5, new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, null, "Relazione con il Cliente", 6 });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CoordinatoreId", "CorsiId", "DataFine", "DataInizio", "InsegnanteId", "InsegnantiId", "Materia", "TutorId" },
                values: new object[] { 4, null, 4, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, null, "Lavorare in team", 7 });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CoordinatoreId", "CorsiId", "DataFine", "DataInizio", "InsegnanteId", "InsegnantiId", "Materia", "TutorId" },
                values: new object[] { 3, null, 3, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, null, "Inglese", 8 });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CoordinatoreId", "CorsiId", "DataFine", "DataInizio", "InsegnanteId", "InsegnantiId", "Materia", "TutorId" },
                values: new object[] { 1, null, 1, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, null, "Programmazione OOP", 9 });

            migrationBuilder.InsertData(
                table: "Moduli",
                columns: new[] { "Id", "CoordinatoreId", "CorsiId", "DataFine", "DataInizio", "InsegnanteId", "InsegnantiId", "Materia", "TutorId" },
                values: new object[] { 2, null, 2, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, null, "C#", 10 });

            migrationBuilder.InsertData(
                table: "Partecipanti",
                columns: new[] { "Id", "AnnoDiploma", "Citta", "Cognome", "CorsiId", "DataNascita", "Diploma", "Email", "EsamiId", "Indirizzo", "IscrizioniId", "Nome", "Telefono" },
                values: new object[] { 1, new DateTime(2010, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cesena", "Polo", 1, new DateTime(2010, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tecnico", "MarcoPolo@gmail.com", null, "Via Polo 29°", 3, "Marco", "3338614937" });

            migrationBuilder.InsertData(
                table: "Partecipanti",
                columns: new[] { "Id", "AnnoDiploma", "Citta", "Cognome", "CorsiId", "DataNascita", "Diploma", "Email", "EsamiId", "Indirizzo", "IscrizioniId", "Nome", "Telefono" },
                values: new object[] { 2, new DateTime(2016, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bologna", "Venere", 2, new DateTime(1995, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sociale", "GiorgiaVenere@gmail.com", null, "Via Venere 219°", 5, "Giorgia", "3338895937" });

            migrationBuilder.InsertData(
                table: "Partecipanti",
                columns: new[] { "Id", "AnnoDiploma", "Citta", "Cognome", "CorsiId", "DataNascita", "Diploma", "Email", "EsamiId", "Indirizzo", "IscrizioniId", "Nome", "Telefono" },
                values: new object[] { 3, new DateTime(2019, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rimini", "Deandrè", 3, new DateTime(2000, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tecnico", "LuigiDeandè@gmail.com", null, "Via Deandè 5°", 4, "Luigi", "3338678437" });

            migrationBuilder.InsertData(
                table: "Partecipanti",
                columns: new[] { "Id", "AnnoDiploma", "Citta", "Cognome", "CorsiId", "DataNascita", "Diploma", "Email", "EsamiId", "Indirizzo", "IscrizioniId", "Nome", "Telefono" },
                values: new object[] { 4, new DateTime(2018, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forlì", "Pane", 4, new DateTime(1999, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tecnico", "MartaPane@gmail.com", null, "Via Pane 15°", 1, "Marta", "3458684937" });

            migrationBuilder.InsertData(
                table: "Partecipanti",
                columns: new[] { "Id", "AnnoDiploma", "Citta", "Cognome", "CorsiId", "DataNascita", "Diploma", "Email", "EsamiId", "Indirizzo", "IscrizioniId", "Nome", "Telefono" },
                values: new object[] { 5, new DateTime(2017, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faenza", "Telo", 5, new DateTime(1998, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tecnico", "GiorgiaTelo@gmail.com", null, "Via Telo 78°", 2, "Giorgia", "3338614937" });

            migrationBuilder.InsertData(
                table: "Esami",
                columns: new[] { "Id", "DataEsame", "ModuliId" },
                values: new object[] { 1, new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.InsertData(
                table: "Esami",
                columns: new[] { "Id", "DataEsame", "ModuliId" },
                values: new object[] { 2, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

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
                values: new object[] { 4, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Esami_ModuliId",
                table: "Esami",
                column: "ModuliId");

            migrationBuilder.CreateIndex(
                name: "IX_Iscrizioni_CorsiId",
                table: "Iscrizioni",
                column: "CorsiId");

            migrationBuilder.CreateIndex(
                name: "IX_Moduli_CoordinatoreId",
                table: "Moduli",
                column: "CoordinatoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Moduli_CorsiId",
                table: "Moduli",
                column: "CorsiId");

            migrationBuilder.CreateIndex(
                name: "IX_Moduli_InsegnantiId",
                table: "Moduli",
                column: "InsegnantiId");

            migrationBuilder.CreateIndex(
                name: "IX_Moduli_TutorId",
                table: "Moduli",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Partecipanti_CorsiId",
                table: "Partecipanti",
                column: "CorsiId");

            migrationBuilder.CreateIndex(
                name: "IX_Partecipanti_EsamiId",
                table: "Partecipanti",
                column: "EsamiId");

            migrationBuilder.CreateIndex(
                name: "IX_Partecipanti_IscrizioniId",
                table: "Partecipanti",
                column: "IscrizioniId");

            migrationBuilder.CreateIndex(
                name: "IX_Personale_CorsiId",
                table: "Personale",
                column: "CorsiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Partecipanti");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Esami");

            migrationBuilder.DropTable(
                name: "Iscrizioni");

            migrationBuilder.DropTable(
                name: "Moduli");

            migrationBuilder.DropTable(
                name: "Personale");

            migrationBuilder.DropTable(
                name: "Corsi");
        }
    }
}
