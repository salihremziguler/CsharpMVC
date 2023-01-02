﻿// <auto-generated />
using System;
using HayvanBarinagiCalisma.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HayvanBarinagiCalisma.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230102092146_mg426")]
    partial class mg426
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HayvanBarinagiCalisma.Models.Araba", b =>
                {
                    b.Property<int>("ArabaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArabaId"), 1L, 1);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EkBilgiler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasarliMi")
                        .HasColumnType("bit");

                    b.Property<int>("MarkaId")
                        .HasColumnType("int");

                    b.Property<int>("Model")
                        .HasColumnType("int");

                    b.Property<bool>("RezerveMi")
                        .HasColumnType("bit");

                    b.Property<int>("TurId")
                        .HasColumnType("int");

                    b.HasKey("ArabaId");

                    b.HasIndex("MarkaId");

                    b.HasIndex("TurId");

                    b.ToTable("Araba");
                });

            modelBuilder.Entity("HayvanBarinagiCalisma.Models.CustomUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("HayvanId")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Rol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "78b89a4a-2401-43ba-af78-b878bfa397ab",
                            DogumTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "b191210049@sakarya.edu.tr",
                            EmailConfirmed = true,
                            HayvanId = 0,
                            LockoutEnabled = false,
                            NormalizedEmail = "B191210049@SAKARYA.EDU.TR",
                            NormalizedUserName = "B191210049@SAKARYA.EDU.TR",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ4FubnPEOoUlNouSyjDfMMAWN2idPQ3JJ3SIbkLWixGzGZi5znw2dKc85sJ3d5iRw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "b191210049@sakarya.edu.tr"
                        },
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b40dcef-56f4-42f9-a9f8-a919fe844581",
                            DogumTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "b181200378@sakarya.edu.tr",
                            EmailConfirmed = true,
                            HayvanId = 0,
                            LockoutEnabled = false,
                            NormalizedEmail = "B181200378@SAKARYA.EDU.TR",
                            NormalizedUserName = "B181200378@SAKARYA.EDU.TR",
                            PasswordHash = "AQAAAAEAACcQAAAAEMlGF+N0HoDOVHKoJVl+zf+7xYodtMXoEQmRx0tx8Br3GIDFNaRLQ0cjT8Gws2g09Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "b181200378@sakarya.edu.tr"
                        },
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "88b9fc17-e34f-45d5-a4f8-f4fdd4097145",
                            DogumTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "g171210105@sakarya.edu.tr",
                            EmailConfirmed = true,
                            HayvanId = 0,
                            LockoutEnabled = false,
                            NormalizedEmail = "G171210105@SAKARYA.EDU.TR",
                            NormalizedUserName = "G171210105@SAKARYA.EDU.TR",
                            PasswordHash = "AQAAAAEAACcQAAAAECvDJ5ZYaWo1fYDiFCNr6lD4y9NBhY3EO8BLtli9OkU0Vht2Av6ziKi0mZ5cdZgRVA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "g171210105@sakarya.edu.tr"
                        });
                });

            modelBuilder.Entity("HayvanBarinagiCalisma.Models.Iletisim", b =>
                {
                    b.Property<int>("IletisimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IletisimId"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mesaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("IletisimId");

                    b.ToTable("Iletisim");
                });

            modelBuilder.Entity("HayvanBarinagiCalisma.Models.Marka", b =>
                {
                    b.Property<int>("MarkaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarkaId"), 1L, 1);

                    b.Property<string>("MarkaAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarkaId");

                    b.ToTable("Marka");
                });

            modelBuilder.Entity("HayvanBarinagiCalisma.Models.Tur", b =>
                {
                    b.Property<int>("TurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TurId"), 1L, 1);

                    b.Property<string>("TurAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TurId");

                    b.ToTable("Tur");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "28ab369a-37df-436d-8a20-ea28285cc62a",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "5aaa1731-af02-4339-be4b-8cb3838434a1",
                            Name = "Uye",
                            NormalizedName = "UYE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HayvanBarinagiCalisma.Models.Araba", b =>
                {
                    b.HasOne("HayvanBarinagiCalisma.Models.Marka", "Marka")
                        .WithMany("Arabalar")
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HayvanBarinagiCalisma.Models.Tur", "Tur")
                        .WithMany("Arabalar")
                        .HasForeignKey("TurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marka");

                    b.Navigation("Tur");
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
                    b.HasOne("HayvanBarinagiCalisma.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HayvanBarinagiCalisma.Models.CustomUser", null)
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

                    b.HasOne("HayvanBarinagiCalisma.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HayvanBarinagiCalisma.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HayvanBarinagiCalisma.Models.Marka", b =>
                {
                    b.Navigation("Arabalar");
                });

            modelBuilder.Entity("HayvanBarinagiCalisma.Models.Tur", b =>
                {
                    b.Navigation("Arabalar");
                });
#pragma warning restore 612, 618
        }
    }
}
