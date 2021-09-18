﻿// <auto-generated />
using System;
using Final___Lab2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final___Lab2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210917203530_sxsxss")]
    partial class sxsxss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Final___Lab2.Models.Analizat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KategoritAnalizaveId")
                        .HasColumnType("int");

                    b.Property<int?>("PagesaId")
                        .HasColumnType("int");

                    b.Property<string>("Pershkerimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TechnicalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoritAnalizaveId");

                    b.HasIndex("PagesaId");

                    b.HasIndex("TechnicalId")
                        .IsUnique();

                    b.ToTable("Analizats");
                });

            modelBuilder.Entity("Final___Lab2.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Final___Lab2.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("KontrollaMjeksoreId")
                        .HasColumnType("int");

                    b.Property<string>("Mbiemri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrPersonal")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int?>("OrariId")
                        .HasColumnType("int");

                    b.Property<string>("Profesioni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specalizimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulli")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("KontrollaMjeksoreId");

                    b.HasIndex("OrariId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Final___Lab2.Models.Faktura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<int>("FaturimiId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrPersonal")
                        .HasColumnType("int");

                    b.Property<int>("PagesaId")
                        .HasColumnType("int");

                    b.Property<int>("Shuma")
                        .HasColumnType("int");

                    b.Property<string>("Valuta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FaturimiId")
                        .IsUnique();

                    b.HasIndex("PagesaId")
                        .IsUnique();

                    b.ToTable("Fakturas");
                });

            modelBuilder.Entity("Final___Lab2.Models.Faturimi", b =>
                {
                    b.Property<int>("FaturimiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kestet")
                        .HasColumnType("int");

                    b.Property<string>("KohaPageses")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FaturimiId");

                    b.ToTable("Faturimis");
                });

            modelBuilder.Entity("Final___Lab2.Models.KategoritAnalizave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kategoria")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KategoritAnalizaves");
                });

            modelBuilder.Entity("Final___Lab2.Models.KontrollaMjeksore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PagesaId")
                        .HasColumnType("int");

                    b.Property<string>("Pershkrimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TerapiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PagesaId")
                        .IsUnique();

                    b.HasIndex("TerapiId");

                    b.ToTable("KontrollaMjeksores");
                });

            modelBuilder.Entity("Final___Lab2.Models.Nurse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnalizaId")
                        .HasColumnType("int");

                    b.Property<string>("Analizat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Mbiemri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrPersonal")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int?>("OrariId")
                        .HasColumnType("int");

                    b.Property<string>("OrariPushimit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesioni")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnalizaId")
                        .IsUnique();

                    b.HasIndex("OrariId");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("Final___Lab2.Models.Orari", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Paradite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pasdite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Oraris");
                });

            modelBuilder.Entity("Final___Lab2.Models.Pacient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnalizatId")
                        .HasColumnType("int");

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("KontrollaMjeksoreId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrPersonal")
                        .HasColumnType("int");

                    b.Property<int?>("PagesaId")
                        .HasColumnType("int");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnalizatId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("KontrollaMjeksoreId");

                    b.HasIndex("PagesaId");

                    b.ToTable("Pacients");
                });

            modelBuilder.Entity("Final___Lab2.Models.Pagesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardHolder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CardNumber")
                        .HasColumnType("bigint");

                    b.Property<bool>("Confirmation")
                        .HasColumnType("bit");

                    b.Property<int?>("ReceptionistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReceptionistId");

                    b.ToTable("Pagesas");
                });

            modelBuilder.Entity("Final___Lab2.Models.Receptionist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Mbiemri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrPersonal")
                        .HasColumnType("int");

                    b.Property<int>("NrTermineve")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int?>("OrariId")
                        .HasColumnType("int");

                    b.Property<string>("OrariPushimit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesioni")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("OrariId");

                    b.ToTable("Receptionists");
                });

            modelBuilder.Entity("Final___Lab2.Models.Technical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Mbiemri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrPersonal")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int?>("OrariId")
                        .HasColumnType("int");

                    b.Property<string>("Pervoja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesioni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shkollimi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrariId");

                    b.ToTable("Technicals");
                });

            modelBuilder.Entity("Final___Lab2.Models.Terapi", b =>
                {
                    b.Property<int>("TerapiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barnat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kohezgjatja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacientiId")
                        .HasColumnType("int");

                    b.Property<string>("Semundje")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TerapiId");

                    b.HasIndex("PacientiId");

                    b.ToTable("Terapis");
                });

            modelBuilder.Entity("Final___Lab2.Models.Analizat", b =>
                {
                    b.HasOne("Final___Lab2.Models.KategoritAnalizave", "KategoritAnalizave")
                        .WithMany("Analizats")
                        .HasForeignKey("KategoritAnalizaveId");

                    b.HasOne("Final___Lab2.Models.Pagesa", "Pagesa")
                        .WithMany("Analizats")
                        .HasForeignKey("PagesaId");

                    b.HasOne("Final___Lab2.Models.Technical", "Technical")
                        .WithOne("Analiza")
                        .HasForeignKey("Final___Lab2.Models.Analizat", "TechnicalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Final___Lab2.Models.Doctor", b =>
                {
                    b.HasOne("Final___Lab2.Models.Appointment", "Appointment")
                        .WithMany("Doctors")
                        .HasForeignKey("AppointmentId");

                    b.HasOne("Final___Lab2.Models.KontrollaMjeksore", "KontrollaMjeksore")
                        .WithMany("Doctors")
                        .HasForeignKey("KontrollaMjeksoreId");

                    b.HasOne("Final___Lab2.Models.Orari", "Orari")
                        .WithMany("Doctors")
                        .HasForeignKey("OrariId");
                });

            modelBuilder.Entity("Final___Lab2.Models.Faktura", b =>
                {
                    b.HasOne("Final___Lab2.Models.Faturimi", "Faturimi")
                        .WithOne("Faktura")
                        .HasForeignKey("Final___Lab2.Models.Faktura", "FaturimiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final___Lab2.Models.Pagesa", "Pagesa")
                        .WithOne("Faktura")
                        .HasForeignKey("Final___Lab2.Models.Faktura", "PagesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Final___Lab2.Models.KontrollaMjeksore", b =>
                {
                    b.HasOne("Final___Lab2.Models.Pagesa", "Pagesa")
                        .WithOne("KontrollaMjeksore")
                        .HasForeignKey("Final___Lab2.Models.KontrollaMjeksore", "PagesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final___Lab2.Models.Terapi", "Terapi")
                        .WithMany("KontrollaMjeksores")
                        .HasForeignKey("TerapiId");
                });

            modelBuilder.Entity("Final___Lab2.Models.Nurse", b =>
                {
                    b.HasOne("Final___Lab2.Models.Analizat", "Analiza")
                        .WithOne("Nurse")
                        .HasForeignKey("Final___Lab2.Models.Nurse", "AnalizaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final___Lab2.Models.Orari", "Orari")
                        .WithMany("Nurses")
                        .HasForeignKey("OrariId");
                });

            modelBuilder.Entity("Final___Lab2.Models.Pacient", b =>
                {
                    b.HasOne("Final___Lab2.Models.Analizat", "Analizat")
                        .WithMany("Pacients")
                        .HasForeignKey("AnalizatId");

                    b.HasOne("Final___Lab2.Models.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId");

                    b.HasOne("Final___Lab2.Models.KontrollaMjeksore", "KontrollaMjeksore")
                        .WithMany("Pacients")
                        .HasForeignKey("KontrollaMjeksoreId");

                    b.HasOne("Final___Lab2.Models.Pagesa", "Pagesa")
                        .WithMany()
                        .HasForeignKey("PagesaId");
                });

            modelBuilder.Entity("Final___Lab2.Models.Pagesa", b =>
                {
                    b.HasOne("Final___Lab2.Models.Receptionist", "Receptionist")
                        .WithMany("Pagesas")
                        .HasForeignKey("ReceptionistId");
                });

            modelBuilder.Entity("Final___Lab2.Models.Receptionist", b =>
                {
                    b.HasOne("Final___Lab2.Models.Appointment", "Appointment")
                        .WithMany("Receptionists")
                        .HasForeignKey("AppointmentId");

                    b.HasOne("Final___Lab2.Models.Orari", "Orari")
                        .WithMany("Receptionists")
                        .HasForeignKey("OrariId");
                });

            modelBuilder.Entity("Final___Lab2.Models.Technical", b =>
                {
                    b.HasOne("Final___Lab2.Models.Orari", "Orari")
                        .WithMany("Technicals")
                        .HasForeignKey("OrariId");
                });

            modelBuilder.Entity("Final___Lab2.Models.Terapi", b =>
                {
                    b.HasOne("Final___Lab2.Models.Pacient", "Pacient")
                        .WithMany("Terapis")
                        .HasForeignKey("PacientiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
