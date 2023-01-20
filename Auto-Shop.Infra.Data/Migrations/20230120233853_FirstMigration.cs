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
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false)
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
                    BrandName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false)
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
                columns: new[] { "Id", "CreatedOn", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { "42cebc4a", new DateTime(2023, 1, 20, 20, 38, 53, 163, DateTimeKind.Local).AddTicks(629), "Ford Motor Company is an American multinational automobile manufacturer.", "http://site.com.br", "Ford" },
                    { "5df6d900", new DateTime(2023, 1, 20, 20, 38, 53, 163, DateTimeKind.Local).AddTicks(1361), "Honda Motor Co., Ltd. is a Japanese public multinational conglomerate manufacturer of automobiles.", "http://site.com.br", "Honda" },
                    { "e91aff9b", new DateTime(2023, 1, 20, 20, 38, 53, 163, DateTimeKind.Local).AddTicks(1368), "Toyota Motor Corporation is a Japanese multinational automotive manufacturer headquartered in Toyota City, Aichi, Japan.", "http://site.com.br", "Toyota" },
                    { "cea2e390", new DateTime(2023, 1, 20, 20, 38, 53, 163, DateTimeKind.Local).AddTicks(1372), "Fiat Automobiles S.p.A. is an Italian automobile manufacturer, formerly part of Fiat Chrysler Automobiles.", "http://site.com.br", "Fiat" },
                    { "ed218cbd", new DateTime(2023, 1, 20, 20, 38, 53, 163, DateTimeKind.Local).AddTicks(1388), "Volkswagen AG, known internationally as the Volkswagen Group, is a German multinational automotive manufacturer.", "http://site.com.br", "Volkswagen" }
                });

            migrationBuilder.InsertData(
                table: "AS_VEHICLES",
                columns: new[] { "Id", "BrandId", "BrandName", "City", "CreatedOn", "ImageUrl", "Km", "Model", "Name", "Price", "State", "Year" },
                values: new object[,]
                {
                    { "b3a14b02", "42cebc4a", null, "São Paulo", new DateTime(2023, 1, 20, 20, 38, 53, 163, DateTimeKind.Local).AddTicks(1560), "http://site.com.br", "69.752", "Sedan", "Ford Focus", 62.900m, "SP", "2015" },
                    { "ae184287", "5df6d900", null, "Rio de Janeiro", new DateTime(2023, 1, 20, 20, 38, 53, 163, DateTimeKind.Local).AddTicks(3173), "http://site.com.br", "54.000", "Sedan", "Honda Civic", 135.000m, "RJ", "2020" },
                    { "a886df53", "e91aff9b", null, "Niterói", new DateTime(2023, 1, 20, 20, 38, 53, 163, DateTimeKind.Local).AddTicks(3181), "http://site.com.br", "111.040", "Sedã", "Toyota Corolla", 71.900m, "RJ", "2013/2014" },
                    { "cf5d60b9", "cea2e390", null, "Santos", new DateTime(2023, 1, 20, 20, 38, 53, 163, DateTimeKind.Local).AddTicks(3186), "http://site.com.br", "82.000", "Hatchback", "Fiat Uno", 42.990m, "SP", "2015" },
                    { "0b0892c5", "ed218cbd", null, "Brasília", new DateTime(2023, 1, 20, 20, 38, 53, 163, DateTimeKind.Local).AddTicks(3190), "http://site.com.br", "23.652", "Sport Utility", "Volkswagen Nivus", 121.000m, "DF", "2020/2021" }
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
