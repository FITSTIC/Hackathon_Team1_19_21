﻿// <auto-generated />
using System;
using Gestionale.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gestionale.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("Gestionale.Data.Corsi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnnoAccademico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AnnoFineCorso")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AnnoInizioCorso")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sede")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Corsi");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnnoAccademico = "21/23",
                            AnnoFineCorso = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AnnoInizioCorso = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Alan Turing",
                            Sede = "Cesena"
                        },
                        new
                        {
                            Id = 2,
                            AnnoAccademico = "21/23",
                            AnnoFineCorso = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AnnoInizioCorso = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Marshall McLuhan",
                            Sede = "Bologna"
                        },
                        new
                        {
                            Id = 3,
                            AnnoAccademico = "21/23",
                            AnnoFineCorso = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AnnoInizioCorso = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Grace Hopper",
                            Sede = "Modena"
                        },
                        new
                        {
                            Id = 4,
                            AnnoAccademico = "21/23",
                            AnnoFineCorso = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AnnoInizioCorso = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Product Manager Fashion",
                            Sede = "Carpi"
                        },
                        new
                        {
                            Id = 5,
                            AnnoAccademico = "21/23",
                            AnnoFineCorso = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AnnoInizioCorso = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Expert Mixed Reality",
                            Sede = "Casalecchio"
                        });
                });

            modelBuilder.Entity("Gestionale.Data.Esami", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataEsame")
                        .HasColumnType("TEXT");

                    b.Property<int>("ModuliId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Punteggio")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ModuliId");

                    b.ToTable("Esami");
                });

            modelBuilder.Entity("Gestionale.Data.Iscrizioni", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CorsiId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataIscrizione")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CorsiId");

                    b.ToTable("Iscrizioni");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CorsiId = 4,
                            DataIscrizione = new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CorsiId = 5,
                            DataIscrizione = new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CorsiId = 1,
                            DataIscrizione = new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CorsiId = 3,
                            DataIscrizione = new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CorsiId = 2,
                            DataIscrizione = new DateTime(2020, 6, 5, 16, 17, 24, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Gestionale.Data.Moduli", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CorsiId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataFine")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInizio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Materia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PersonaleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CorsiId");

                    b.HasIndex("PersonaleId");

                    b.ToTable("Moduli");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CorsiId = 1,
                            DataFine = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInizio = new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Materia = "Programmazione OOP"
                        });
                });

            modelBuilder.Entity("Gestionale.Data.Partecipanti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AnnoDiploma")
                        .HasColumnType("TEXT");

                    b.Property<string>("Citta")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CorsiId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataNascita")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diploma")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Indirizzo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IscrizioniId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CorsiId");

                    b.HasIndex("IscrizioniId");

                    b.ToTable("Partecipanti");
                });

            modelBuilder.Entity("Gestionale.Data.Personale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Assunzione")
                        .HasColumnType("TEXT");

                    b.Property<int>("Categorie")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CorsiId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataNascita")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CorsiId");

                    b.ToTable("Personale");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Gestionale.Data.Esami", b =>
                {
                    b.HasOne("Gestionale.Data.Moduli", "Moduli")
                        .WithMany("Esami")
                        .HasForeignKey("ModuliId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gestionale.Data.Iscrizioni", b =>
                {
                    b.HasOne("Gestionale.Data.Corsi", "Corsi")
                        .WithMany()
                        .HasForeignKey("CorsiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gestionale.Data.Moduli", b =>
                {
                    b.HasOne("Gestionale.Data.Corsi", "Corsi")
                        .WithMany("Moduli")
                        .HasForeignKey("CorsiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestionale.Data.Personale", "Personale")
                        .WithMany("Moduli")
                        .HasForeignKey("PersonaleId");
                });

            modelBuilder.Entity("Gestionale.Data.Partecipanti", b =>
                {
                    b.HasOne("Gestionale.Data.Corsi", "Corsi")
                        .WithMany("Partecipanti")
                        .HasForeignKey("CorsiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestionale.Data.Iscrizioni", "Iscrizioni")
                        .WithMany("Partecipanti")
                        .HasForeignKey("IscrizioniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gestionale.Data.Personale", b =>
                {
                    b.HasOne("Gestionale.Data.Corsi", "Corsi")
                        .WithMany("Personale")
                        .HasForeignKey("CorsiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
