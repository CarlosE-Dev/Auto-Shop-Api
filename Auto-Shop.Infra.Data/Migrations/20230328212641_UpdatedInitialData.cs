using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Auto_Shop.Infra.Data.Migrations
{
    public partial class UpdatedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "33a344c7", "Ford Motor Company is an American multinational automobile manufacturer.", "http://site.com.br", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(4228), "Ford" },
                    { "d07ed587", "Honda Motor Co., Ltd. is a Japanese public multinational conglomerate manufacturer of automobiles.", "http://site.com.br", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(4959), "Honda" },
                    { "bb011c9d", "Toyota Motor Corporation is a Japanese multinational automotive manufacturer headquartered in Toyota City, Aichi, Japan.", "http://site.com.br", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(4967), "Toyota" },
                    { "1de5a4df", "Fiat Automobiles S.p.A. is an Italian automobile manufacturer, formerly part of Fiat Chrysler Automobiles.", "http://site.com.br", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(4971), "Fiat" },
                    { "f5445a75", "Volkswagen AG, known internationally as the Volkswagen Group, is a German multinational automotive manufacturer.", "http://site.com.br", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(4975), "Volkswagen" }
                });

            migrationBuilder.InsertData(
                table: "AS_ROLES",
                columns: new[] { "Id", "ModifiedOn", "RoleName" },
                values: new object[] { "e23a26a2", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(7130), "ADMIN" });

            migrationBuilder.InsertData(
                table: "AS_USERS",
                columns: new[] { "Id", "ModifiedOn", "Password", "RoleId", "Username" },
                values: new object[] { "48454888", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(7558), "1AbYhcg*!@3", "e23a26a2", "adm@adm.com" });

            migrationBuilder.InsertData(
                table: "AS_VEHICLES",
                columns: new[] { "Id", "BrandId", "City", "ImageUrl", "Km", "Model", "ModifiedOn", "Name", "Price", "State", "Year" },
                values: new object[,]
                {
                    { "1f3d32eb", "33a344c7", "São Paulo", "https://media.discordapp.net/attachments/1050461916474122251/1090383696936312873/Focus_2015.jpg?width=901&height=676", "69.752", "Sedan", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(5164), "Ford Focus", 62.900m, "SP", "2015/2016" },
                    { "3b780597", "33a344c7", "São Paulo", "https://media.discordapp.net/attachments/1050461916474122251/1090384159622574120/Maverick_2022.jpg?width=901&height=676", "28.652", "Pickup", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6865), "Ford Maverick", 241.000m, "SP", "2022/2022" },
                    { "67a83f4e", "33a344c7", "Rio de Janeiro", "https://media.discordapp.net/attachments/1050461916474122251/1090384541635579955/Territory_2020.jpg?width=901&height=676", "18.652", "Sport Utility", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6901), "Ford Territory", 150.000m, "RJ", "2020/2021" },
                    { "8102db8b", "d07ed587", "Rio de Janeiro", "https://media.discordapp.net/attachments/1050461916474122251/1090383697338962040/Civic_2020.jpg?width=901&height=676", "54.000", "Sedan", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6842), "Honda Civic", 135.000m, "RJ", "2020/2021" },
                    { "45c3c0a3", "d07ed587", "Recife", "https://media.discordapp.net/attachments/1050461916474122251/1090384541400703126/Hr-v_2017.jpg?width=901&height=676", "44.000", "Sport Utility", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6906), "Honda HR-V", 135.000m, "PE", "2017/2018" },
                    { "5430af77", "d07ed587", "Niterói", "https://media.discordapp.net/attachments/1050461916474122251/1090384541136453752/City_2019.jpg?width=901&height=676", "52.000", "Sedan", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6915), "Honda City", 91.000m, "RJ", "2019/2020" },
                    { "e9bafea1", "bb011c9d", "Niterói", "https://media.discordapp.net/attachments/1050461916474122251/1090383697737425016/Corolla_2014.jpg?width=901&height=676", "111.040", "Sedan", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6851), "Toyota Corolla", 71.900m, "RJ", "2013/2014" },
                    { "67835f4e", "bb011c9d", "São Gonçalo", "https://media.discordapp.net/attachments/1050461916474122251/1090384776600489984/Yaris_2020.jpg?width=901&height=676", "25.000", "Sedan", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6919), "Toyota Yaris", 96.900m, "RJ", "2020/2020" },
                    { "158c7878", "bb011c9d", "Diadema", "https://media.discordapp.net/attachments/1050461916474122251/1090384776856359052/SW4_2017.jpg?width=901&height=676", "71.300", "Sport Utility", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6922), "Toyota Hilux SW4", 315.900m, "SP", "2017/2018" },
                    { "02a486a5", "1de5a4df", "Santos", "https://media.discordapp.net/attachments/1050461916474122251/1090384159035367424/Uno_2015.jpg?width=901&height=676", "82.000", "Hatchback", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6856), "Fiat Uno", 42.990m, "SP", "2015/2016" },
                    { "7763331e", "1de5a4df", "Vitória", "https://media.discordapp.net/attachments/1050461916474122251/1090384777124778054/Fiat_Bravo_2014.jpg?width=901&height=676", "140.000", "Hatchback", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6926), "Fiat Bravo", 43.700m, "ES", "2013/2014" },
                    { "2351e4ae", "1de5a4df", "Salvador", "https://media.discordapp.net/attachments/1050461916474122251/1090384916266627082/Argo_2018.jpg?width=901&height=676", "71.000", "Hatchback", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6930), "Fiat Argo", 51.000m, "BA", "2018/2018" },
                    { "a20650e9", "f5445a75", "Brasília", "https://media.discordapp.net/attachments/1050461916474122251/1090384159349952572/Nivus_2020.jpg?width=901&height=676", "23.652", "Sport Utility", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6860), "Volkswagen Nivus", 121.000m, "DF", "2020/2021" },
                    { "f38942b7", "f5445a75", "Natal", "https://media.discordapp.net/attachments/1050461916474122251/1090384916543455242/Polo_2022.jpg", "5.000", "Hatchback", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6933), "Volkswagen Polo", 108.000m, "RN", "2022/2023" },
                    { "e9ad663d", "f5445a75", "Vila Velha", "https://media.discordapp.net/attachments/1050461916474122251/1090384916744773695/Jetta_2017.jpg?width=901&height=676", "78.652", "Sedan", new DateTime(2023, 3, 28, 18, 26, 41, 492, DateTimeKind.Local).AddTicks(6937), "Volkswagen Jetta", 92.000m, "ES", "2017/2018" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AS_ROLES",
                keyColumn: "Id",
                keyValue: "e23a26a2");

            migrationBuilder.DeleteData(
                table: "AS_USERS",
                keyColumn: "Id",
                keyValue: "48454888");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "02a486a5");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "158c7878");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "1f3d32eb");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "2351e4ae");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "3b780597");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "45c3c0a3");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "5430af77");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "67835f4e");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "67a83f4e");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "7763331e");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "8102db8b");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "a20650e9");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "e9ad663d");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "e9bafea1");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "f38942b7");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "1de5a4df");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "33a344c7");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "bb011c9d");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "d07ed587");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "f5445a75");

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
        }
    }
}
