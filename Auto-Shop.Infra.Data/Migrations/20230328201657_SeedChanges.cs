using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Auto_Shop.Infra.Data.Migrations
{
    public partial class SeedChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AS_ROLES",
                keyColumn: "Id",
                keyValue: "6e6c22e5");

            migrationBuilder.DeleteData(
                table: "AS_USERS",
                keyColumn: "Id",
                keyValue: "b8b5e363");

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
                    { "4d658abf", "Ford Motor Company is an American multinational automobile manufacturer.", "http://site.com.br", new DateTime(2023, 3, 28, 17, 16, 57, 291, DateTimeKind.Local).AddTicks(2042), "Ford" },
                    { "b65f24df", "Honda Motor Co., Ltd. is a Japanese public multinational conglomerate manufacturer of automobiles.", "http://site.com.br", new DateTime(2023, 3, 28, 17, 16, 57, 291, DateTimeKind.Local).AddTicks(2788), "Honda" },
                    { "5d953bd2", "Toyota Motor Corporation is a Japanese multinational automotive manufacturer headquartered in Toyota City, Aichi, Japan.", "http://site.com.br", new DateTime(2023, 3, 28, 17, 16, 57, 291, DateTimeKind.Local).AddTicks(2795), "Toyota" },
                    { "64af3255", "Fiat Automobiles S.p.A. is an Italian automobile manufacturer, formerly part of Fiat Chrysler Automobiles.", "http://site.com.br", new DateTime(2023, 3, 28, 17, 16, 57, 291, DateTimeKind.Local).AddTicks(2800), "Fiat" },
                    { "393dd12c", "Volkswagen AG, known internationally as the Volkswagen Group, is a German multinational automotive manufacturer.", "http://site.com.br", new DateTime(2023, 3, 28, 17, 16, 57, 291, DateTimeKind.Local).AddTicks(2804), "Volkswagen" }
                });

            migrationBuilder.InsertData(
                table: "AS_ROLES",
                columns: new[] { "Id", "ModifiedOn", "RoleName" },
                values: new object[] { "f3016a70", new DateTime(2023, 3, 28, 17, 16, 57, 291, DateTimeKind.Local).AddTicks(4921), "ADMIN" });

            migrationBuilder.InsertData(
                table: "AS_USERS",
                columns: new[] { "Id", "ModifiedOn", "Password", "RoleId", "Username" },
                values: new object[] { "de3da888", new DateTime(2023, 3, 28, 17, 16, 57, 291, DateTimeKind.Local).AddTicks(5238), "1AbYhcg*!@3", "f3016a70", "adm@adm.com" });

            migrationBuilder.InsertData(
                table: "AS_VEHICLES",
                columns: new[] { "Id", "BrandId", "City", "ImageUrl", "Km", "Model", "ModifiedOn", "Name", "Price", "State", "Year" },
                values: new object[,]
                {
                    { "4a518449", "4d658abf", "São Paulo", "http://site.com.br", "69.752", "Sedan", new DateTime(2023, 3, 28, 17, 16, 57, 291, DateTimeKind.Local).AddTicks(3035), "Ford Focus", 62.900m, "SP", "2015" },
                    { "2c00bee7", "b65f24df", "Rio de Janeiro", "http://site.com.br", "54.000", "Sedan", new DateTime(2023, 3, 28, 17, 16, 57, 291, DateTimeKind.Local).AddTicks(4717), "Honda Civic", 135.000m, "RJ", "2020" },
                    { "8fbc6dc7", "5d953bd2", "Niterói", "http://site.com.br", "111.040", "Sedan", new DateTime(2023, 3, 28, 17, 16, 57, 291, DateTimeKind.Local).AddTicks(4726), "Toyota Corolla", 71.900m, "RJ", "2013/2014" },
                    { "7b78baf7", "64af3255", "Santos", "http://site.com.br", "82.000", "Hatchback", new DateTime(2023, 3, 28, 17, 16, 57, 291, DateTimeKind.Local).AddTicks(4735), "Fiat Uno", 42.990m, "SP", "2015" },
                    { "e9cfa31f", "393dd12c", "Brasília", "http://site.com.br", "23.652", "Sport Utility", new DateTime(2023, 3, 28, 17, 16, 57, 291, DateTimeKind.Local).AddTicks(4739), "Volkswagen Nivus", 121.000m, "DF", "2020/2021" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AS_USERS_Username",
                table: "AS_USERS",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AS_USERS_Username",
                table: "AS_USERS");

            migrationBuilder.DeleteData(
                table: "AS_ROLES",
                keyColumn: "Id",
                keyValue: "f3016a70");

            migrationBuilder.DeleteData(
                table: "AS_USERS",
                keyColumn: "Id",
                keyValue: "de3da888");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "2c00bee7");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "4a518449");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "7b78baf7");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "8fbc6dc7");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "e9cfa31f");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "393dd12c");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "4d658abf");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "5d953bd2");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "64af3255");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "b65f24df");

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
    }
}
