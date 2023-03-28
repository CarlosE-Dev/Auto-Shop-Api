﻿// <auto-generated />
using System;
using Auto_Shop.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Auto_Shop.Infra.Data.Migrations
{
    [DbContext(typeof(AutoShopContext))]
    partial class AutoShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Auto_Shop.Domain.Models.Brand", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("AS_BRANDS");

                    b.HasData(
                        new
                        {
                            Id = "bce39932",
                            Description = "Ford Motor Company is an American multinational automobile manufacturer.",
                            ImageUrl = "http://site.com.br",
                            ModifiedOn = new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(6519),
                            Name = "Ford"
                        },
                        new
                        {
                            Id = "87783640",
                            Description = "Honda Motor Co., Ltd. is a Japanese public multinational conglomerate manufacturer of automobiles.",
                            ImageUrl = "http://site.com.br",
                            ModifiedOn = new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(7260),
                            Name = "Honda"
                        },
                        new
                        {
                            Id = "f6978ec6",
                            Description = "Toyota Motor Corporation is a Japanese multinational automotive manufacturer headquartered in Toyota City, Aichi, Japan.",
                            ImageUrl = "http://site.com.br",
                            ModifiedOn = new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(7269),
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = "038adb78",
                            Description = "Fiat Automobiles S.p.A. is an Italian automobile manufacturer, formerly part of Fiat Chrysler Automobiles.",
                            ImageUrl = "http://site.com.br",
                            ModifiedOn = new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(7274),
                            Name = "Fiat"
                        },
                        new
                        {
                            Id = "3cc02364",
                            Description = "Volkswagen AG, known internationally as the Volkswagen Group, is a German multinational automotive manufacturer.",
                            ImageUrl = "http://site.com.br",
                            ModifiedOn = new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(7278),
                            Name = "Volkswagen"
                        });
                });

            modelBuilder.Entity("Auto_Shop.Domain.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("AS_ROLES");

                    b.HasData(
                        new
                        {
                            Id = "6e6c22e5",
                            ModifiedOn = new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(9263),
                            RoleName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Auto_Shop.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("RoleId")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("AS_USERS");

                    b.HasData(
                        new
                        {
                            Id = "b8b5e363",
                            ModifiedOn = new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(9632),
                            Password = "1AbYhcg*!@3",
                            RoleId = "6e6c22e5",
                            Username = "adm@adm.com"
                        });
                });

            modelBuilder.Entity("Auto_Shop.Domain.Models.Vehicle", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BrandId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ImageUrl")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasDefaultValue("http://");

                    b.Property<string>("Km")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("AS_VEHICLES");

                    b.HasData(
                        new
                        {
                            Id = "b06d4d87",
                            BrandId = "bce39932",
                            City = "São Paulo",
                            ImageUrl = "http://site.com.br",
                            Km = "69.752",
                            Model = "Sedan",
                            ModifiedOn = new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(7452),
                            Name = "Ford Focus",
                            Price = 62.900m,
                            State = "SP",
                            Year = "2015"
                        },
                        new
                        {
                            Id = "9ee143c1",
                            BrandId = "87783640",
                            City = "Rio de Janeiro",
                            ImageUrl = "http://site.com.br",
                            Km = "54.000",
                            Model = "Sedan",
                            ModifiedOn = new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(9024),
                            Name = "Honda Civic",
                            Price = 135.000m,
                            State = "RJ",
                            Year = "2020"
                        },
                        new
                        {
                            Id = "3baae012",
                            BrandId = "f6978ec6",
                            City = "Niterói",
                            ImageUrl = "http://site.com.br",
                            Km = "111.040",
                            Model = "Sedan",
                            ModifiedOn = new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(9036),
                            Name = "Toyota Corolla",
                            Price = 71.900m,
                            State = "RJ",
                            Year = "2013/2014"
                        },
                        new
                        {
                            Id = "bad6f1c0",
                            BrandId = "038adb78",
                            City = "Santos",
                            ImageUrl = "http://site.com.br",
                            Km = "82.000",
                            Model = "Hatchback",
                            ModifiedOn = new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(9041),
                            Name = "Fiat Uno",
                            Price = 42.990m,
                            State = "SP",
                            Year = "2015"
                        },
                        new
                        {
                            Id = "d9f73904",
                            BrandId = "3cc02364",
                            City = "Brasília",
                            ImageUrl = "http://site.com.br",
                            Km = "23.652",
                            Model = "Sport Utility",
                            ModifiedOn = new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(9045),
                            Name = "Volkswagen Nivus",
                            Price = 121.000m,
                            State = "DF",
                            Year = "2020/2021"
                        });
                });

            modelBuilder.Entity("Auto_Shop.Domain.Models.Vehicle", b =>
                {
                    b.HasOne("Auto_Shop.Domain.Models.Brand", "Brand")
                        .WithMany("Vehicles")
                        .HasForeignKey("BrandId")
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Auto_Shop.Domain.Models.Brand", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
