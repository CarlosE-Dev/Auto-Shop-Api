using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Auto_Shop.Infra.Data.Migrations
{
    public partial class Authentication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "19c87903");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "48fec4df");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "630b0ab8");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "d4250daf");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "f8eafeb1");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "1853cee3");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "4b6dd8c1");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "86604869");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "917f79ac");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "c554577b");

            migrationBuilder.CreateTable(
                name: "AS_ROLES",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AS_ROLES", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AS_USERS",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AS_USERS", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AS_BRANDS",
                columns: new[] { "Id", "Description", "ImageUrl", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { "bce39932", "Ford Motor Company is an American multinational automobile manufacturer.", "http://site.com.br", new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(6519), "Ford" },
                    { "87783640", "Honda Motor Co., Ltd. is a Japanese public multinational conglomerate manufacturer of automobiles.", "http://site.com.br", new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(7260), "Honda" },
                    { "f6978ec6", "Toyota Motor Corporation is a Japanese multinational automotive manufacturer headquartered in Toyota City, Aichi, Japan.", "http://site.com.br", new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(7269), "Toyota" },
                    { "038adb78", "Fiat Automobiles S.p.A. is an Italian automobile manufacturer, formerly part of Fiat Chrysler Automobiles.", "http://site.com.br", new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(7274), "Fiat" },
                    { "3cc02364", "Volkswagen AG, known internationally as the Volkswagen Group, is a German multinational automotive manufacturer.", "http://site.com.br", new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(7278), "Volkswagen" }
                });

            migrationBuilder.InsertData(
                table: "AS_ROLES",
                columns: new[] { "Id", "ModifiedOn", "RoleName" },
                values: new object[] { "6e6c22e5", new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(9263), "ADMIN" });

            migrationBuilder.InsertData(
                table: "AS_USERS",
                columns: new[] { "Id", "ModifiedOn", "Password", "RoleId", "Username" },
                values: new object[] { "b8b5e363", new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(9632), "1AbYhcg*!@3", "6e6c22e5", "adm@adm.com" });

            migrationBuilder.InsertData(
                table: "AS_VEHICLES",
                columns: new[] { "Id", "BrandId", "City", "ImageUrl", "Km", "Model", "ModifiedOn", "Name", "Price", "State", "Year" },
                values: new object[,]
                {
                    { "b06d4d87", "bce39932", "São Paulo", "http://site.com.br", "69.752", "Sedan", new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(7452), "Ford Focus", 62.900m, "SP", "2015" },
                    { "9ee143c1", "87783640", "Rio de Janeiro", "http://site.com.br", "54.000", "Sedan", new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(9024), "Honda Civic", 135.000m, "RJ", "2020" },
                    { "3baae012", "f6978ec6", "Niterói", "http://site.com.br", "111.040", "Sedan", new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(9036), "Toyota Corolla", 71.900m, "RJ", "2013/2014" },
                    { "bad6f1c0", "038adb78", "Santos", "http://site.com.br", "82.000", "Hatchback", new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(9041), "Fiat Uno", 42.990m, "SP", "2015" },
                    { "d9f73904", "3cc02364", "Brasília", "http://site.com.br", "23.652", "Sport Utility", new DateTime(2023, 3, 27, 19, 9, 34, 167, DateTimeKind.Local).AddTicks(9045), "Volkswagen Nivus", 121.000m, "DF", "2020/2021" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AS_ROLES");

            migrationBuilder.DropTable(
                name: "AS_USERS");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "3baae012");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "9ee143c1");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "b06d4d87");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "bad6f1c0");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "d9f73904");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "038adb78");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "3cc02364");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "87783640");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "bce39932");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "f6978ec6");

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
        }
    }
}
