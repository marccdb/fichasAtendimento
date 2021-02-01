﻿// <auto-generated />
using System;
using FichaAtendimento.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FichaAtendimento.Server.Migrations
{
    [DbContext(typeof(FichaContext))]
    [Migration("20210131221034_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("FichaAtendimento.Server.Model.Ficha", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AbordagemProxSessao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CID10_DSM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CondutaClinica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAtendimento")
                        .HasColumnType("date");

                    b.Property<string>("NomePaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProxTarefa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ReciboEntregue")
                        .HasColumnType("bit");

                    b.Property<string>("ResumoAtendimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SessaoPaga")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Fichas");
                });
#pragma warning restore 612, 618
        }
    }
}
