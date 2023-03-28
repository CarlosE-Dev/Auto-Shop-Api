using Auto_Shop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.Intrinsics.X86;

namespace Auto_Shop.Infra.Data.Context
{
    public static class AutoShopDbSeeder
    {
        #region Brand Data

        public static Brand Ford = new Brand()
        {
            Name = "Ford",
            Description = "Ford Motor Company is an American multinational automobile manufacturer.",
            ImageUrl = "http://site.com.br"
        };

        public static Brand Honda = new Brand()
        {
            Name = "Honda",
            Description = "Honda Motor Co., Ltd. is a Japanese public multinational conglomerate manufacturer of automobiles.",
            ImageUrl = "http://site.com.br"
        };

        public static Brand Toyota = new Brand()
        {
            Name = "Toyota",
            Description = "Toyota Motor Corporation is a Japanese multinational automotive manufacturer headquartered in Toyota City, Aichi, Japan.",
            ImageUrl = "http://site.com.br"
        };

        public static Brand Fiat = new Brand()
        {
            Name = "Fiat",
            Description = "Fiat Automobiles S.p.A. is an Italian automobile manufacturer, formerly part of Fiat Chrysler Automobiles.",
            ImageUrl = "http://site.com.br"
        };

        public static Brand Volkswagen = new Brand()
        {
            Name = "Volkswagen",
            Description = "Volkswagen AG, known internationally as the Volkswagen Group, is a German multinational automotive manufacturer.",
            ImageUrl = "http://site.com.br"
        };

        #endregion

        #region Vehicle Data

        public static Vehicle Focus = new Vehicle() 
        { 
            Name = "Ford Focus", 
            BrandId = Ford.Id, 
            City = "São Paulo",
            State = "SP",
            Km = "69.752", 
            Year = "2015/2016", 
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090383696936312873/Focus_2015.jpg?width=901&height=676", 
            Model = "Sedan", 
            Price = 62.900m 
        };

        public static Vehicle Civic = new Vehicle() 
        { 
            Name = "Honda Civic", 
            BrandId = Honda.Id, 
            City = "Rio de Janeiro",
            State = "RJ",
            Km = "54.000", 
            Year = "2020/2021", 
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090383697338962040/Civic_2020.jpg?width=901&height=676", 
            Model = "Sedan", 
            Price = 135.000m 
        };

        public static Vehicle Corolla = new Vehicle() 
        { 
            Name = "Toyota Corolla", 
            BrandId = Toyota.Id, 
            City = "Niterói",
            State = "RJ",
            Km = "111.040", 
            Year = "2013/2014", 
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090383697737425016/Corolla_2014.jpg?width=901&height=676", 
            Model = "Sedan", 
            Price = 71.900m 
        };

        public static Vehicle Uno = new Vehicle()
        {
            Name = "Fiat Uno",
            BrandId = Fiat.Id,
            City = "Santos",
            State = "SP",
            Km = "82.000",
            Year = "2015/2016",
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090384159035367424/Uno_2015.jpg?width=901&height=676",
            Model = "Hatchback",
            Price = 42.990m
        };

        public static Vehicle Nivus = new Vehicle()
        {
            Name = "Volkswagen Nivus",
            BrandId = Volkswagen.Id,
            City = "Brasília",
            State = "DF",
            Km = "23.652",
            Year = "2020/2021",
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090384159349952572/Nivus_2020.jpg?width=901&height=676",
            Model = "Sport Utility",
            Price = 121.000m
        };

        public static Vehicle Maverick = new Vehicle()
        {
            Name = "Ford Maverick",
            BrandId = Ford.Id,
            City = "São Paulo",
            State = "SP",
            Km = "28.652",
            Year = "2022/2022",
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090384159622574120/Maverick_2022.jpg?width=901&height=676",
            Model = "Pickup",
            Price = 241.000m
        };

        public static Vehicle Territory = new Vehicle()
        {
            Name = "Ford Territory",
            BrandId = Ford.Id,
            City = "Rio de Janeiro",
            State = "RJ",
            Km = "18.652",
            Year = "2020/2021",
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090384541635579955/Territory_2020.jpg?width=901&height=676",
            Model = "Sport Utility",
            Price = 150.000m
        };

        public static Vehicle HRV = new Vehicle()
        {
            Name = "Honda HR-V",
            BrandId = Honda.Id,
            City = "Recife",
            State = "PE",
            Km = "44.000",
            Year = "2017/2018",
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090384541400703126/Hr-v_2017.jpg?width=901&height=676",
            Model = "Sport Utility",
            Price = 135.000m
        };

        public static Vehicle City = new Vehicle()
        {
            Name = "Honda City",
            BrandId = Honda.Id,
            City = "Niterói",
            State = "RJ",
            Km = "52.000",
            Year = "2019/2020",
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090384541136453752/City_2019.jpg?width=901&height=676",
            Model = "Sedan",
            Price = 91.000m
        };

        public static Vehicle Yaris = new Vehicle()
        {
            Name = "Toyota Yaris",
            BrandId = Toyota.Id,
            City = "São Gonçalo",
            State = "RJ",
            Km = "25.000",
            Year = "2020/2020",
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090384776600489984/Yaris_2020.jpg?width=901&height=676",
            Model = "Sedan",
            Price = 96.900m
        };

        public static Vehicle HiluxSW4 = new Vehicle()
        {
            Name = "Toyota Hilux SW4",
            BrandId = Toyota.Id,
            City = "Diadema",
            State = "SP",
            Km = "71.300",
            Year = "2017/2018",
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090384776856359052/SW4_2017.jpg?width=901&height=676",
            Model = "Sport Utility",
            Price = 315.900m
        };

        public static Vehicle Bravo = new Vehicle()
        {
            Name = "Fiat Bravo",
            BrandId = Fiat.Id,
            City = "Vitória",
            State = "ES",
            Km = "140.000",
            Year = "2013/2014",
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090384777124778054/Fiat_Bravo_2014.jpg?width=901&height=676",
            Model = "Hatchback",
            Price = 43.700m
        };

        public static Vehicle Argo = new Vehicle()
        {
            Name = "Fiat Argo",
            BrandId = Fiat.Id,
            City = "Salvador",
            State = "BA",
            Km = "71.000",
            Year = "2018/2018",
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090384916266627082/Argo_2018.jpg?width=901&height=676",
            Model = "Hatchback",
            Price = 51.000m
        };

        public static Vehicle Polo = new Vehicle()
        {
            Name = "Volkswagen Polo",
            BrandId = Volkswagen.Id,
            City = "Natal",
            State = "RN",
            Km = "5.000",
            Year = "2022/2023",
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090384916543455242/Polo_2022.jpg",
            Model = "Hatchback",
            Price = 108.000m
        };

        public static Vehicle Jetta = new Vehicle()
        {
            Name = "Volkswagen Jetta",
            BrandId = Volkswagen.Id,
            City = "Vila Velha",
            State = "ES",
            Km = "78.652",
            Year = "2017/2018",
            ImageUrl = "https://media.discordapp.net/attachments/1050461916474122251/1090384916744773695/Jetta_2017.jpg?width=901&height=676",
            Model = "Sedan",
            Price = 92.000m
        };

        #endregion

        #region Role Data

        public static Role RoleAdmin = new Role()
        {
            RoleName = "ADMIN",
        };

        #endregion

        #region User Data 

        public static User UserAdmnistrator = new User()
        {
            Username = "adm@adm.com",
            Password = "1AbYhcg*!@3",
            RoleId = RoleAdmin.Id
        };

        #endregion

        public static void SeedInitialData(ModelBuilder modelBuilder)
        {

            #region Brand Data

            modelBuilder.Entity<Brand>()
                .HasData(
                    AutoShopDbSeeder.Ford,
                    AutoShopDbSeeder.Honda,
                    AutoShopDbSeeder.Toyota,
                    AutoShopDbSeeder.Fiat,
                    AutoShopDbSeeder.Volkswagen
                );
            #endregion

            #region Vehicle Data

            modelBuilder.Entity<Vehicle>()
                .HasData(
                    AutoShopDbSeeder.Focus,
                    AutoShopDbSeeder.Civic,
                    AutoShopDbSeeder.Corolla,
                    AutoShopDbSeeder.Uno,
                    AutoShopDbSeeder.Nivus,
                    AutoShopDbSeeder.Maverick,
                    AutoShopDbSeeder.Territory,
                    AutoShopDbSeeder.HRV,
                    AutoShopDbSeeder.City,
                    AutoShopDbSeeder.Yaris,
                    AutoShopDbSeeder.HiluxSW4,
                    AutoShopDbSeeder.Bravo,
                    AutoShopDbSeeder.Argo,
                    AutoShopDbSeeder.Polo,
                    AutoShopDbSeeder.Jetta
                );

            #endregion

            #region Role Data

            modelBuilder.Entity<Role>()
                .HasData(
                    AutoShopDbSeeder.RoleAdmin
                );

            #endregion

            #region User Data

            modelBuilder.Entity<User>()
                .HasData(
                    AutoShopDbSeeder.UserAdmnistrator
                );

            #endregion

        }
    }
}
