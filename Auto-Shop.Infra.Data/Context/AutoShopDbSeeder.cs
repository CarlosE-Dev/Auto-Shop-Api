using Auto_Shop.Domain.Models;

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
            Year = "2015", 
            ImageUrl = "http://site.com.br", 
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
            Year = "2020", 
            ImageUrl = "http://site.com.br", 
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
            ImageUrl = "http://site.com.br", 
            Model = "Sedã", 
            Price = 71.900m 
        };

        public static Vehicle Uno = new Vehicle()
        {
            Name = "Fiat Uno",
            BrandId = Fiat.Id,
            City = "Santos",
            State = "SP",
            Km = "82.000",
            Year = "2015",
            ImageUrl = "http://site.com.br",
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
            ImageUrl = "http://site.com.br",
            Model = "Sport Utility",
            Price = 121.000m
        };

        #endregion
    }
}
