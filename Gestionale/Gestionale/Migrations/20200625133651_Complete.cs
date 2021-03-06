﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestionale.Migrations
{
    public partial class Complete : Migration
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
                name: "Dipendente",
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
                    CorsiId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dipendente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dipendente_Corsi_CorsiId",
                        column: x => x.CorsiId,
                        principalTable: "Corsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dipendente_Corsi_CorsiId1",
                        column: x => x.CorsiId,
                        principalTable: "Corsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dipendente_Corsi_CorsiId2",
                        column: x => x.CorsiId,
                        principalTable: "Corsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Iscrizioni",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataIscrizione = table.Column<DateTime>(nullable: false),
                    CorsiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iscrizioni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Iscrizioni_Corsi_CorsiId",
                        column: x => x.CorsiId,
                        principalTable: "Corsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    TutorId = table.Column<int>(nullable: true),
                    DipendenteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moduli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moduli_Corsi_CorsiId",
                        column: x => x.CorsiId,
                        principalTable: "Corsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Moduli_Dipendente_DipendenteId",
                        column: x => x.DipendenteId,
                        principalTable: "Dipendente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Moduli_Dipendente_InsegnanteId",
                        column: x => x.InsegnanteId,
                        principalTable: "Dipendente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Moduli_Dipendente_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Dipendente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    CorsiId = table.Column<int>(nullable: true),
                    IscrizioneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partecipanti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partecipanti_Corsi_CorsiId",
                        column: x => x.CorsiId,
                        principalTable: "Corsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partecipanti_Iscrizioni_IscrizioneId",
                        column: x => x.IscrizioneId,
                        principalTable: "Iscrizioni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Esami",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ModuliId = table.Column<int>(nullable: false),
                    DataEsame = table.Column<DateTime>(nullable: false),
                    Punteggio = table.Column<double>(nullable: true)
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
                name: "Punteggi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Voto = table.Column<double>(nullable: true),
                    PartecipanteId = table.Column<int>(nullable: false),
                    EsameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Punteggi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Punteggi_Esami_EsameId",
                        column: x => x.EsameId,
                        principalTable: "Esami",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Punteggi_Partecipanti_PartecipanteId",
                        column: x => x.PartecipanteId,
                        principalTable: "Partecipanti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_Dipendente_CorsiId",
                table: "Dipendente",
                column: "CorsiId");

            migrationBuilder.CreateIndex(
                name: "IX_Dipendente_CorsiId1",
                table: "Dipendente",
                column: "CorsiId");

            migrationBuilder.CreateIndex(
                name: "IX_Dipendente_CorsiId2",
                table: "Dipendente",
                column: "CorsiId");

            migrationBuilder.CreateIndex(
                name: "IX_Esami_ModuliId",
                table: "Esami",
                column: "ModuliId");

            migrationBuilder.CreateIndex(
                name: "IX_Iscrizioni_CorsiId",
                table: "Iscrizioni",
                column: "CorsiId");

            migrationBuilder.CreateIndex(
                name: "IX_Moduli_CorsiId",
                table: "Moduli",
                column: "CorsiId");

            migrationBuilder.CreateIndex(
                name: "IX_Moduli_DipendenteId",
                table: "Moduli",
                column: "DipendenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Moduli_InsegnanteId",
                table: "Moduli",
                column: "InsegnanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Moduli_TutorId",
                table: "Moduli",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Partecipanti_CorsiId",
                table: "Partecipanti",
                column: "CorsiId");

            migrationBuilder.CreateIndex(
                name: "IX_Partecipanti_IscrizioneId",
                table: "Partecipanti",
                column: "IscrizioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Punteggi_EsameId",
                table: "Punteggi",
                column: "EsameId");

            migrationBuilder.CreateIndex(
                name: "IX_Punteggi_PartecipanteId",
                table: "Punteggi",
                column: "PartecipanteId");
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
                name: "Punteggi");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Esami");

            migrationBuilder.DropTable(
                name: "Partecipanti");

            migrationBuilder.DropTable(
                name: "Moduli");

            migrationBuilder.DropTable(
                name: "Iscrizioni");

            migrationBuilder.DropTable(
                name: "Dipendente");

            migrationBuilder.DropTable(
                name: "Corsi");
        }
    }
}
