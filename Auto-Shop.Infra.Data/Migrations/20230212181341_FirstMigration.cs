using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Auto_Shop.Infra.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AS_BRANDS",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageUrl = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AS_BRANDS", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AS_VEHICLES",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BrandId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Model = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageUrl = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true, defaultValue: "http://")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Year = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Km = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AS_VEHICLES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AS_VEHICLES_AS_BRANDS_BrandId",
                        column: x => x.BrandId,
                        principalTable: "AS_BRANDS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AS_BRANDS",
                columns: new[] { "Id", "Description", "ImageUrl", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { "4b6dd8c1", "Ford Motor Company is an American multinational automobile manufacturer.", "http://site.com.br", new DateTime(2023, 2, 12, 15, 13, 41, 603, DateTimeKind.Local).AddTicks(219), "Ford" },
                    { "1853cee3", "Honda Motor Co., Ltd. is a Japanese public multinational conglomerate manufacturer of automobiles.", "http://site.com.br", new DateTime(2023, 2, 12, 15, 13, 41, 603, DateTimeKind.Local).AddTicks(930), "Honda" },
                    { "86604869", "Toyota Motor Corporation is a Japanese multinational automotive manufacturer headquartered in Toyota City, Aichi, Japan.", "http://site.com.br", new DateTime(2023, 2, 12, 15, 13, 41, 603, DateTimeKind.Local).AddTicks(938), "Toyota" },
                    { "c554577b", "Fiat Automobiles S.p.A. is an Italian automobile manufacturer, formerly part of Fiat Chrysler Automobiles.", "http://site.com.br", new DateTime(2023, 2, 12, 15, 13, 41, 603, DateTimeKind.Local).AddTicks(942), "Fiat" },
                    { "917f79ac", "Volkswagen AG, known internationally as the Volkswagen Group, is a German multinational automotive manufacturer.", "http://site.com.br", new DateTime(2023, 2, 12, 15, 13, 41, 603, DateTimeKind.Local).AddTicks(945), "Volkswagen" }
                });

            migrationBuilder.InsertData(
                table: "AS_VEHICLES",
                columns: new[] { "Id", "BrandId", "City", "ImageUrl", "Km", "Model", "ModifiedOn", "Name", "Price", "State", "Year" },
                values: new object[,]
                {
                    { "19c87903", "4b6dd8c1", "São Paulo", "http://site.com.br", "69.752", "Sedan", new DateTime(2023, 2, 12, 15, 13, 41, 603, DateTimeKind.Local).AddTicks(1111), "Ford Focus", 62.900m, "SP", "2015" },
                    { "f8eafeb1", "1853cee3", "Rio de Janeiro", "http://site.com.br", "54.000", "Sedan", new DateTime(2023, 2, 12, 15, 13, 41, 603, DateTimeKind.Local).AddTicks(2777), "Honda Civic", 135.000m, "RJ", "2020" },
                    { "48fec4df", "86604869", "Niterói", "http://site.com.br", "111.040", "Sedã", new DateTime(2023, 2, 12, 15, 13, 41, 603, DateTimeKind.Local).AddTicks(2786), "Toyota Corolla", 71.900m, "RJ", "2013/2014" },
                    { "d4250daf", "c554577b", "Santos", "http://site.com.br", "82.000", "Hatchback", new DateTime(2023, 2, 12, 15, 13, 41, 603, DateTimeKind.Local).AddTicks(2791), "Fiat Uno", 42.990m, "SP", "2015" },
                    { "630b0ab8", "917f79ac", "Brasília", "http://site.com.br", "23.652", "Sport Utility", new DateTime(2023, 2, 12, 15, 13, 41, 603, DateTimeKind.Local).AddTicks(2795), "Volkswagen Nivus", 121.000m, "DF", "2020/2021" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AS_VEHICLES_BrandId",
                table: "AS_VEHICLES",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AS_VEHICLES");

            migrationBuilder.DropTable(
                name: "AS_BRANDS");
        }
    }
}
