﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DL.Migrations
{
    [DbContext(typeof(DDDBContext))]
    [Migration("20220206070834_UpdatedGameController")]
    partial class UpdatedGameController
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.GameControl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Action")
                        .HasColumnType("integer");

                    b.Property<int>("ActionID")
                        .HasColumnType("integer");

                    b.Property<int>("GameTurn")
                        .HasColumnType("integer");

                    b.Property<int>("P1HP")
                        .HasColumnType("integer");

                    b.Property<int>("P1MaxHP")
                        .HasColumnType("integer");

                    b.Property<int>("P1fc")
                        .HasColumnType("integer");

                    b.Property<int>("P1mv")
                        .HasColumnType("integer");

                    b.Property<int>("P2HP")
                        .HasColumnType("integer");

                    b.Property<int>("P2MaxHP")
                        .HasColumnType("integer");

                    b.Property<int>("P2fc")
                        .HasColumnType("integer");

                    b.Property<int>("P2mv")
                        .HasColumnType("integer");

                    b.Property<int>("P3HP")
                        .HasColumnType("integer");

                    b.Property<int>("P3MaxHP")
                        .HasColumnType("integer");

                    b.Property<int>("P3fc")
                        .HasColumnType("integer");

                    b.Property<int>("P3mv")
                        .HasColumnType("integer");

                    b.Property<int>("P4HP")
                        .HasColumnType("integer");

                    b.Property<int>("P4MaxHP")
                        .HasColumnType("integer");

                    b.Property<int>("P4fc")
                        .HasColumnType("integer");

                    b.Property<int>("P4mv")
                        .HasColumnType("integer");

                    b.Property<int>("Players")
                        .HasColumnType("integer");

                    b.Property<string>("TargetName")
                        .HasColumnType("text");

                    b.Property<string>("p1Name")
                        .HasColumnType("text");

                    b.Property<string>("p2Name")
                        .HasColumnType("text");

                    b.Property<string>("p3Name")
                        .HasColumnType("text");

                    b.Property<string>("p4Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Models.Scoreboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("GamesPlayed")
                        .HasColumnType("integer");

                    b.Property<int>("GamesWon")
                        .HasColumnType("integer");

                    b.Property<int>("TotalKills")
                        .HasColumnType("integer");

                    b.Property<string>("UserFirst")
                        .HasColumnType("text");

                    b.Property<string>("UserSecond")
                        .HasColumnType("text");

                    b.Property<string>("UserThird")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}