using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Auto_Shop.Infra.Data.Migrations
{
    public partial class AddedImgLinkToSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "AS_VEHICLES",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                defaultValue: "https://media.discordapp.net/attachments/1050461916474122251/1090388025021833286/image.png",
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true,
                oldDefaultValue: "http://")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AS_BRANDS",
                columns: new[] { "Id", "Description", "ImageUrl", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { "c6774b3e", "Ford Motor Company is an American multinational automobile manufacturer.", "http://site.com.br", new DateTime(2023, 3, 28, 18, 34, 22, 162, DateTimeKind.Local).AddTicks(8754), "Ford" },
                    { "4f2dfd40", "Honda Motor Co., Ltd. is a Japanese public multinational conglomerate manufacturer of automobiles.", "http://site.com.br", new DateTime(2023, 3, 28, 18, 34, 22, 162, DateTimeKind.Local).AddTicks(9487), "Honda" },
                    { "cf61fc5f", "Toyota Motor Corporation is a Japanese multinational automotive manufacturer headquartered in Toyota City, Aichi, Japan.", "http://site.com.br", new DateTime(2023, 3, 28, 18, 34, 22, 162, DateTimeKind.Local).AddTicks(9495), "Toyota" },
                    { "cf6b1d3e", "Fiat Automobiles S.p.A. is an Italian automobile manufacturer, formerly part of Fiat Chrysler Automobiles.", "http://site.com.br", new DateTime(2023, 3, 28, 18, 34, 22, 162, DateTimeKind.Local).AddTicks(9499), "Fiat" },
                    { "7db471fc", "Volkswagen AG, known internationally as the Volkswagen Group, is a German multinational automotive manufacturer.", "http://site.com.br", new DateTime(2023, 3, 28, 18, 34, 22, 162, DateTimeKind.Local).AddTicks(9503), "Volkswagen" }
                });

            migrationBuilder.InsertData(
                table: "AS_ROLES",
                columns: new[] { "Id", "ModifiedOn", "RoleName" },
                values: new object[] { "ec519658", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1637), "ADMIN" });

            migrationBuilder.InsertData(
                table: "AS_USERS",
                columns: new[] { "Id", "ModifiedOn", "Password", "RoleId", "Username" },
                values: new object[] { "47baf253", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1954), "1AbYhcg*!@3", "ec519658", "adm@adm.com" });

            migrationBuilder.InsertData(
                table: "AS_VEHICLES",
                columns: new[] { "Id", "BrandId", "City", "ImageUrl", "Km", "Model", "ModifiedOn", "Name", "Price", "State", "Year" },
                values: new object[,]
                {
                    { "eeb7c9d6", "c6774b3e", "São Paulo", "https://media.discordapp.net/attachments/1050461916474122251/1090383696936312873/Focus_2015.jpg?width=901&height=676", "69.752", "Sedan", new DateTime(2023, 3, 28, 18, 34, 22, 162, DateTimeKind.Local).AddTicks(9677), "Ford Focus", 62.900m, "SP", "2015/2016" },
                    { "adf55f88", "c6774b3e", "São Paulo", "https://media.discordapp.net/attachments/1050461916474122251/1090384159622574120/Maverick_2022.jpg?width=901&height=676", "28.652", "Pickup", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1394), "Ford Maverick", 241.000m, "SP", "2022/2022" },
                    { "8fff5eb6", "c6774b3e", "Rio de Janeiro", "https://media.discordapp.net/attachments/1050461916474122251/1090384541635579955/Territory_2020.jpg?width=901&height=676", "18.652", "Sport Utility", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1399), "Ford Territory", 150.000m, "RJ", "2020/2021" },
                    { "8f75f59e", "4f2dfd40", "Rio de Janeiro", "https://media.discordapp.net/attachments/1050461916474122251/1090383697338962040/Civic_2020.jpg?width=901&height=676", "54.000", "Sedan", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1300), "Honda Civic", 135.000m, "RJ", "2020/2021" },
                    { "bc106379", "4f2dfd40", "Recife", "https://media.discordapp.net/attachments/1050461916474122251/1090384541400703126/Hr-v_2017.jpg?width=901&height=676", "44.000", "Sport Utility", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1403), "Honda HR-V", 135.000m, "PE", "2017/2018" },
                    { "3f1f5735", "4f2dfd40", "Niterói", "https://media.discordapp.net/attachments/1050461916474122251/1090384541136453752/City_2019.jpg?width=901&height=676", "52.000", "Sedan", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1407), "Honda City", 91.000m, "RJ", "2019/2020" },
                    { "45d5272f", "cf61fc5f", "Niterói", "https://media.discordapp.net/attachments/1050461916474122251/1090383697737425016/Corolla_2014.jpg?width=901&height=676", "111.040", "Sedan", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1348), "Toyota Corolla", 71.900m, "RJ", "2013/2014" },
                    { "dfd13430", "cf61fc5f", "São Gonçalo", "https://media.discordapp.net/attachments/1050461916474122251/1090384776600489984/Yaris_2020.jpg?width=901&height=676", "25.000", "Sedan", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1414), "Toyota Yaris", 96.900m, "RJ", "2020/2020" },
                    { "d374ae9d", "cf61fc5f", "Diadema", "https://media.discordapp.net/attachments/1050461916474122251/1090384776856359052/SW4_2017.jpg?width=901&height=676", "71.300", "Sport Utility", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1418), "Toyota Hilux SW4", 315.900m, "SP", "2017/2018" },
                    { "e588d0eb", "cf6b1d3e", "Santos", "https://media.discordapp.net/attachments/1050461916474122251/1090384159035367424/Uno_2015.jpg?width=901&height=676", "82.000", "Hatchback", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1352), "Fiat Uno", 42.990m, "SP", "2015/2016" },
                    { "f15ba2cd", "cf6b1d3e", "Vitória", "https://media.discordapp.net/attachments/1050461916474122251/1090384777124778054/Fiat_Bravo_2014.jpg?width=901&height=676", "140.000", "Hatchback", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1422), "Fiat Bravo", 43.700m, "ES", "2013/2014" },
                    { "127cdf6f", "cf6b1d3e", "Salvador", "https://media.discordapp.net/attachments/1050461916474122251/1090384916266627082/Argo_2018.jpg?width=901&height=676", "71.000", "Hatchback", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1426), "Fiat Argo", 51.000m, "BA", "2018/2018" },
                    { "62fa8fd2", "7db471fc", "Brasília", "https://media.discordapp.net/attachments/1050461916474122251/1090384159349952572/Nivus_2020.jpg?width=901&height=676", "23.652", "Sport Utility", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1357), "Volkswagen Nivus", 121.000m, "DF", "2020/2021" },
                    { "7278eaea", "7db471fc", "Natal", "https://media.discordapp.net/attachments/1050461916474122251/1090384916543455242/Polo_2022.jpg", "5.000", "Hatchback", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1430), "Volkswagen Polo", 108.000m, "RN", "2022/2023" },
                    { "0db3eb7c", "7db471fc", "Vila Velha", "https://media.discordapp.net/attachments/1050461916474122251/1090384916744773695/Jetta_2017.jpg?width=901&height=676", "78.652", "Sedan", new DateTime(2023, 3, 28, 18, 34, 22, 163, DateTimeKind.Local).AddTicks(1434), "Volkswagen Jetta", 92.000m, "ES", "2017/2018" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AS_ROLES",
                keyColumn: "Id",
                keyValue: "ec519658");

            migrationBuilder.DeleteData(
                table: "AS_USERS",
                keyColumn: "Id",
                keyValue: "47baf253");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "0db3eb7c");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "127cdf6f");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "3f1f5735");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "45d5272f");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "62fa8fd2");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "7278eaea");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "8f75f59e");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "8fff5eb6");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "adf55f88");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "bc106379");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "d374ae9d");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "dfd13430");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "e588d0eb");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "eeb7c9d6");

            migrationBuilder.DeleteData(
                table: "AS_VEHICLES",
                keyColumn: "Id",
                keyValue: "f15ba2cd");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "4f2dfd40");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "7db471fc");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "c6774b3e");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "cf61fc5f");

            migrationBuilder.DeleteData(
                table: "AS_BRANDS",
                keyColumn: "Id",
                keyValue: "cf6b1d3e");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "AS_VEHICLES",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                defaultValue: "http://",
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true,
                oldDefaultValue: "https://media.discordapp.net/attachments/1050461916474122251/1090388025021833286/image.png")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
    }
}
