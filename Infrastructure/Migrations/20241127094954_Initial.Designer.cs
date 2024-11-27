﻿// <auto-generated />
using System;
using Infrastructure.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(UchebkaDbContext))]
    [Migration("20241127094954_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Electricity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CheckDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("check_date");

                    b.Property<int>("PeopleAmount")
                        .HasColumnType("integer")
                        .HasColumnName("people_amount");

                    b.Property<double>("SpendAmount")
                        .HasColumnType("double precision")
                        .HasColumnName("spend_amount");

                    b.HasKey("Id");

                    b.ToTable("Electricities");
                });

            modelBuilder.Entity("Domain.Entities.Gas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CheckDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("check_date");

                    b.Property<int>("PeopleAmount")
                        .HasColumnType("integer")
                        .HasColumnName("people_amount");

                    b.Property<double>("SpendAmount")
                        .HasColumnType("double precision")
                        .HasColumnName("spend_amount");

                    b.HasKey("Id");

                    b.ToTable("Gases");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Water", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CheckDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("check_date");

                    b.Property<int>("PeopleAmount")
                        .HasColumnType("integer")
                        .HasColumnName("people_amount");

                    b.Property<double>("SpendAmount")
                        .HasColumnType("double precision")
                        .HasColumnName("spend_amount");

                    b.HasKey("Id");

                    b.ToTable("Waters");
                });
#pragma warning restore 612, 618
        }
    }
}
