﻿// <auto-generated />
using System;
using Game_Loan_Management.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Game_Loan_Management.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250314190448_UpdateGenreEnum")]
    partial class UpdateGenreEnum
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Game_Loan_Management.Models.LoanModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Borrower")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Game")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Genre")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Lender")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.ToTable("Loans");
                });
#pragma warning restore 612, 618
        }
    }
}
