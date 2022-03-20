﻿// <auto-generated />
using System;
using Hdogs.api.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hdogs.api.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20220320174407_firstV5")]
    partial class firstV5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Hdogs.api.Model.Entity.Admin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<long>("AuthDataId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.HasIndex("AuthDataId");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.AuthData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("auth_data");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Client", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<long>("AuthDataId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.HasIndex("AuthDataId");

                    b.ToTable("client");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.DocumentType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<long?>("AdminId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<long?>("MonitorId")
                        .HasColumnType("bigint");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasColumnName("type");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("ClientId");

                    b.HasIndex("MonitorId");

                    b.HasIndex("Value")
                        .IsUnique();

                    b.ToTable("document");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Monitor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<long>("AdminId")
                        .HasColumnType("bigint");

                    b.Property<long>("AuthDataId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("AuthDataId");

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Pet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<int>("Size")
                        .HasColumnType("int")
                        .HasColumnName("size");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasColumnName("type");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("pet");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Service", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<long>("MonitorId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<long>("PetId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("MonitorId");

                    b.HasIndex("PetId");

                    b.ToTable("service");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Admin", b =>
                {
                    b.HasOne("Hdogs.api.Model.Entity.AuthData", "AuthData")
                        .WithMany()
                        .HasForeignKey("AuthDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AuthData");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Client", b =>
                {
                    b.HasOne("Hdogs.api.Model.Entity.AuthData", "AuthData")
                        .WithMany()
                        .HasForeignKey("AuthDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AuthData");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.DocumentType", b =>
                {
                    b.HasOne("Hdogs.api.Model.Entity.Admin", null)
                        .WithMany("Documents")
                        .HasForeignKey("AdminId");

                    b.HasOne("Hdogs.api.Model.Entity.Client", null)
                        .WithMany("Documents")
                        .HasForeignKey("ClientId");

                    b.HasOne("Hdogs.api.Model.Entity.Monitor", null)
                        .WithMany("Documents")
                        .HasForeignKey("MonitorId");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Monitor", b =>
                {
                    b.HasOne("Hdogs.api.Model.Entity.Admin", "Admin")
                        .WithMany("Monitors")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hdogs.api.Model.Entity.AuthData", "AuthData")
                        .WithMany()
                        .HasForeignKey("AuthDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("AuthData");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Pet", b =>
                {
                    b.HasOne("Hdogs.api.Model.Entity.Client", "Client")
                        .WithMany("Pets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Service", b =>
                {
                    b.HasOne("Hdogs.api.Model.Entity.Client", "Client")
                        .WithMany("Services")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hdogs.api.Model.Entity.Monitor", "Monitor")
                        .WithMany("Services")
                        .HasForeignKey("MonitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hdogs.api.Model.Entity.Pet", "Pet")
                        .WithMany("Services")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Monitor");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Admin", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Monitors");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Client", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Pets");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Monitor", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("Hdogs.api.Model.Entity.Pet", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
