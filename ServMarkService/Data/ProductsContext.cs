using Microsoft.EntityFrameworkCore;
using ServMarkService.Models;
using ServMarkService.Models.Product;

namespace ServMarkService.Data;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Image> Images { get; set; }
    public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Categories
        var categoriesInit = new List<Category>()
        {
            new ()
            {
                Id = 1,
                Name = "Clothes",
                TypeImg = "people"
            },
            new ()
            {
                Id = 2,
                Name = "Electronics",
                TypeImg = "tech"
            },
            new ()
            {
                Id = 3,
                Name = "Furniture",
                TypeImg = "arch"
            },
            new ()
            {
                Id = 4,
                Name = "Toys",
                TypeImg = "any"
            },
            new ()
            {
                Id = 5,
                Name = "Others",
                TypeImg = "animals"
            },
        };
        
        modelBuilder.Entity<Category>(category =>
        {
            category.ToTable("Category");
            category.HasKey(p => p.Id);
            category.Property(p => p.Id).UseIdentityColumn();
            category.Property(p => p.Name).IsRequired().HasMaxLength(150);
            category.Property(p => p.TypeImg).IsRequired().HasMaxLength(50);
            category.HasData(categoriesInit);
        });
        #endregion
        
        #region Products
        var productsInit = new List<Product>
        {
            new ()
            {
                Id = 1,
                Title = "Handcrafted Metal Towels",
                Price = 349,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 2,
                Title = "Fantastic Granite Shirt",
                Price = 724,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 3,
                Title = "Gorgeous Soft Shoes",
                Price = 834,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 4,
                Title = "Awesome Wooden Shirt",
                Price = 122,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 5,
                Title = "Small Frozen Ball",
                Price = 690,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 6,
                Title = "Handcrafted Frozen Sausages",
                Price = 360,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 7,
                Title = "Ergonomic Plastic Mouse",
                Price = 572,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 8,
                Title = "Gorgeous Frozen Fish",
                Price = 972,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 9,
                Title = "Gorgeous Cotton Cheese",
                Price = 547,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 10,
                Title = "Fantastic Frozen Pants",
                Price = 806,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 11,
                Title = "Unbranded Fresh Cheese",
                Price = 830,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 12,
                Title = "Ergonomic Cotton Car",
                Price = 306,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 13,
                Title = "Sleek Fresh Keyboard",
                Price = 794,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 14,
                Title = "Handmade Steel Hat",
                Price = 223,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 15,
                Title = "Licensed Concrete Towels",
                Price = 910,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 16,
                Title = "Intelligent Wooden Salad",
                Price = 851,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 17,
                Title = "Handmade Granite Tuna",
                Price = 468,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 18,
                Title = "Unbranded Concrete Ball",
                Price = 842,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 19,
                Title = "Rustic Cotton Computer",
                Price = 524,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 20,
                Title = "Rustic Cotton Mouse",
                Price = 401,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 21,
                Title = "Licensed Cotton Salad",
                Price = 249,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 22,
                Title = "Awesome Plastic Shirt",
                Price = 880,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 23,
                Title = "Handcrafted Steel Pizza",
                Price = 663,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 24,
                Title = "Tasty Wooden Pizza",
                Price = 490,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 25,
                Title = "Ergonomic Plastic Chicken",
                Price = 931,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 26,
                Title = "Fantastic Steel Hat",
                Price = 121,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 27,
                Title = "Practical Wooden Keyboard",
                Price = 759,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 28,
                Title = "Tasty Metal Hat",
                Price = 997,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 29,
                Title = "Refined Plastic Tuna",
                Price = 902,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 30,
                Title = "Generic Metal Cheese",
                Price = 517,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 31,
                Title = "Fantastic Concrete Hat",
                Price = 458,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 32,
                Title = "Sleek Wooden Bacon",
                Price = 179,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 33,
                Title = "Intelligent Metal Car",
                Price = 142,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 34,
                Title = "Gorgeous Plastic Soap",
                Price = 593,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 35,
                Title = "Small Fresh Table",
                Price = 666,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 36,
                Title = "Small Granite Car",
                Price = 254,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 37,
                Title = "Small Concrete Hat",
                Price = 459,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 38,
                Title = "Tasty Concrete Car",
                Price = 985,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 39,
                Title = "Ergonomic Cotton Ball",
                Price = 740,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 40,
                Title = "Intelligent Metal Car",
                Price = 754,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 41,
                Title = "Ergonomic Fresh Table",
                Price = 675,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 42,
                Title = "Sleek Soft Chicken",
                Price = 412,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 43,
                Title = "Generic Soft Chips",
                Price = 911,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 44,
                Title = "Handcrafted Metal Soap",
                Price = 468,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 45,
                Title = "Ergonomic Rubber Cheese",
                Price = 994,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 46,
                Title = "Generic Metal Bike",
                Price = 883,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 47,
                Title = "Gorgeous Wooden Hat",
                Price = 981,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 48,
                Title = "Ergonomic Wooden Hat",
                Price = 201,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 49,
                Title = "Generic Metal Chair",
                Price = 814,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 50,
                Title = "Refined Wooden Car",
                Price = 622,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 51,
                Title = "Fantastic Granite Chicken",
                Price = 581,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 52,
                Title = "Tasty Metal Bacon",
                Price = 392,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 53,
                Title = "Small Plastic Bacon",
                Price = 516,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 54,
                Title = "Practical Plastic Shirt",
                Price = 305,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 55,
                Title = "Gorgeous Wooden Computer",
                Price = 677,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 56,
                Title = "Generic Rubber Tuna",
                Price = 864,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 57,
                Title = "Rustic Concrete Car",
                Price = 989,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 58,
                Title = "Handmade Concrete Hat",
                Price = 787,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 59,
                Title = "Rustic Soft Bacon",
                Price = 748,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 60,
                Title = "Small Fresh Tuna",
                Price = 905,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 61,
                Title = "Small Fresh Bacon",
                Price = 298,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 62,
                Title = "Incredible Steel Ball",
                Price = 815,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 63,
                Title = "Rustic Granite Table",
                Price = 76,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 64,
                Title = "Ergonomic Plastic Pants",
                Price = 744,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 65,
                Title = "Small Soft Tuna",
                Price = 739,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 66,
                Title = "Generic Granite Chair",
                Price = 486,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 67,
                Title = "Gorgeous Steel Car",
                Price = 384,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 68,
                Title = "Small Fresh Gloves",
                Price = 818,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 69,
                Title = "Rustic Frozen Soap",
                Price = 34,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 70,
                Title = "Gorgeous Soft Salad",
                Price = 899,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 71,
                Title = "Fantastic Concrete Chair",
                Price = 806,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 72,
                Title = "Handmade Metal Gloves",
                Price = 481,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 73,
                Title = "Sleek Wooden Ball",
                Price = 525,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 74,
                Title = "Generic Plastic Fish",
                Price = 192,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 75,
                Title = "Unbranded Frozen Keyboard",
                Price = 98,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 76,
                Title = "Licensed Fresh Soap",
                Price = 943,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 77,
                Title = "Handmade Granite Mouse",
                Price = 235,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 78,
                Title = "Refined Steel Keyboard",
                Price = 887,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 79,
                Title = "Refined Soft Hat",
                Price = 184,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 80,
                Title = "Small Fresh Sausages",
                Price = 203,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 81,
                Title = "Handmade Cotton Tuna",
                Price = 331,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 82,
                Title = "Intelligent Granite Chair",
                Price = 23,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 83,
                Title = "Handmade Concrete Table",
                Price = 947,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 84,
                Title = "Awesome Plastic Chicken",
                Price = 2,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 85,
                Title = "Ergonomic Cotton Gloves",
                Price = 112,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 86,
                Title = "Awesome Steel Gloves",
                Price = 474,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 87,
                Title = "Rustic Soft Tuna",
                Price = 662,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 88,
                Title = "Handmade Wooden Chicken",
                Price = 571,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 89,
                Title = "Fantastic Granite Pants",
                Price = 249,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 90,
                Title = "Refined Concrete Gloves",
                Price = 636,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 91,
                Title = "Practical Wooden Gloves",
                Price = 891,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 92,
                Title = "Gorgeous Cotton Towels",
                Price = 54,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 93,
                Title = "Intelligent Metal Towels",
                Price = 893,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 94,
                Title = "Incredible Fresh Car",
                Price = 218,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 95,
                Title = "Unbranded Steel Sausages",
                Price = 525,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 96,
                Title = "Sleek Steel Bike",
                Price = 193,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 97,
                Title = "Awesome Metal Sausages",
                Price = 410,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 98,
                Title = "Gorgeous Frozen Chips",
                Price = 251,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 99,
                Title = "Licensed Wooden Sausages",
                Price = 681,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 100,
                Title = "Ergonomic Rubber Ball",
                Price = 415,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 101,
                Title = "Handcrafted Rubber Sausages",
                Price = 264,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 102,
                Title = "Sleek Cotton Chair",
                Price = 547,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 103,
                Title = "Rustic Frozen Pants",
                Price = 866,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 104,
                Title = "Tasty Steel Car",
                Price = 801,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 105,
                Title = "Awesome Rubber Chair",
                Price = 511,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 106,
                Title = "Tasty Rubber Cheese",
                Price = 714,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 107,
                Title = "Gorgeous Cotton Computer",
                Price = 685,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 108,
                Title = "Ergonomic Soft Tuna",
                Price = 466,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 109,
                Title = "Handcrafted Wooden Gloves",
                Price = 602,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 110,
                Title = "Awesome Steel Chips",
                Price = 272,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 111,
                Title = "Tasty Granite Table",
                Price = 227,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 112,
                Title = "Practical Frozen Keyboard",
                Price = 345,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 113,
                Title = "Practical Granite Pizza",
                Price = 320,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 114,
                Title = "Handmade Metal Mouse",
                Price = 784,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 115,
                Title = "Refined Wooden Car",
                Price = 329,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 116,
                Title = "Practical Wooden Bike",
                Price = 161,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 117,
                Title = "Handmade Rubber Towels",
                Price = 694,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 118,
                Title = "Generic Fresh Chicken",
                Price = 802,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 119,
                Title = "Small Granite Bacon",
                Price = 658,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 120,
                Title = "Rustic Wooden Pants",
                Price = 241,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 121,
                Title = "Generic Plastic Bike",
                Price = 113,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 122,
                Title = "Rustic Rubber Towels",
                Price = 297,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 123,
                Title = "Handcrafted Metal Chips",
                Price = 654,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 124,
                Title = "Refined Soft Towels",
                Price = 674,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 125,
                Title = "Generic Granite Cheese",
                Price = 838,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 126,
                Title = "Handcrafted Wooden Salad",
                Price = 82,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 127,
                Title = "Generic Wooden Car",
                Price = 535,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 128,
                Title = "Incredible Steel Bike",
                Price = 488,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 129,
                Title = "Refined Wooden Sausages",
                Price = 725,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 130,
                Title = "Small Cotton Chicken",
                Price = 591,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 131,
                Title = "Small Frozen Ball",
                Price = 319,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 132,
                Title = "Handcrafted Concrete Ball",
                Price = 572,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 133,
                Title = "Refined Steel Tuna",
                Price = 945,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 134,
                Title = "Intelligent Soft Fish",
                Price = 933,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 135,
                Title = "Incredible Steel Pizza",
                Price = 628,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 136,
                Title = "Gorgeous Cotton Keyboard",
                Price = 61,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 137,
                Title = "Awesome Steel Ball",
                Price = 550,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 138,
                Title = "Licensed Steel Shoes",
                Price = 947,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 139,
                Title = "Practical Fresh Car",
                Price = 1,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 140,
                Title = "Gorgeous Soft Shirt",
                Price = 583,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 141,
                Title = "Practical Soft Chicken",
                Price = 835,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 142,
                Title = "Refined Wooden Car",
                Price = 999,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 143,
                Title = "Awesome Plastic Mouse",
                Price = 229,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 144,
                Title = "Gorgeous Rubber Bacon",
                Price = 761,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 145,
                Title = "Fantastic Wooden Pants",
                Price = 640,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 146,
                Title = "Awesome Plastic Bike",
                Price = 74,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 147,
                Title = "Generic Cotton Fish",
                Price = 976,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 148,
                Title = "Ergonomic Concrete Keyboard",
                Price = 134,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 149,
                Title = "Licensed Frozen Ball",
                Price = 831,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 150,
                Title = "Handcrafted Steel Bacon",
                Price = 278,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 151,
                Title = "Small Cotton Fish",
                Price = 495,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 152,
                Title = "Generic Plastic Salad",
                Price = 814,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 153,
                Title = "Tasty Steel Shirt",
                Price = 656,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 154,
                Title = "Ergonomic Rubber Bacon",
                Price = 177,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 155,
                Title = "Handmade Fresh Car",
                Price = 493,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 156,
                Title = "Incredible Metal Ball",
                Price = 823,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 157,
                Title = "Intelligent Concrete Bike",
                Price = 731,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 158,
                Title = "Handmade Steel Car",
                Price = 81,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 159,
                Title = "Generic Steel Hat",
                Price = 550,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 160,
                Title = "Unbranded Granite Ball",
                Price = 807,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 161,
                Title = "Licensed Metal Table",
                Price = 798,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 162,
                Title = "Handcrafted Fresh Ball",
                Price = 632,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 163,
                Title = "Practical Steel Salad",
                Price = 527,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 164,
                Title = "Small Rubber Pizza",
                Price = 2,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 165,
                Title = "Handmade Steel Cheese",
                Price = 951,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 166,
                Title = "Generic Granite Bacon",
                Price = 804,
                Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 167,
                Title = "Intelligent Metal Pizza",
                Price = 266,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 168,
                Title = "Intelligent Fresh Bike",
                Price = 369,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 169,
                Title = "Fantastic Concrete Chair",
                Price = 702,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 170,
                Title = "Small Fresh Soap",
                Price = 91,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 171,
                Title = "Licensed Soft Soap",
                Price = 958,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 172,
                Title = "Awesome Metal Ball",
                Price = 867,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 173,
                Title = "Incredible Soft Hat",
                Price = 626,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 174,
                Title = "Handcrafted Soft Tuna",
                Price = 184,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 175,
                Title = "Licensed Concrete Pizza",
                Price = 140,
                Description = "The Football Is Good For Training And Recreational Purposes",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 176,
                Title = "Generic Soft Gloves",
                Price = 590,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 177,
                Title = "Tasty Plastic Bike",
                Price = 446,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 178,
                Title = "Licensed Rubber Towels",
                Price = 16,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 179,
                Title = "Small Frozen Fish",
                Price = 574,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 180,
                Title = "Intelligent Metal Ball",
                Price = 55,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 181,
                Title = "Practical Soft Bacon",
                Price = 792,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 182,
                Title = "Handcrafted Soft Car",
                Price = 882,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 183,
                Title = "Generic Cotton Fish",
                Price = 901,
                Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 184,
                Title = "Intelligent Granite Towels",
                Price = 37,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 185,
                Title = "Small Rubber Chicken",
                Price = 170,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 186,
                Title = "Generic Fresh Sausages",
                Price = 480,
                Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 187,
                Title = "Ergonomic Concrete Bike",
                Price = 555,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 188,
                Title = "Generic Fresh Computer",
                Price = 800,
                Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 189,
                Title = "Rustic Metal Pizza",
                Price = 34,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 190,
                Title = "Generic Steel Tuna",
                Price = 410,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 191,
                Title = "Licensed Frozen Shoes",
                Price = 521,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 192,
                Title = "Ergonomic Frozen Chips",
                Price = 588,
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 193,
                Title = "Tasty Fresh Pants",
                Price = 937,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 194,
                Title = "Small Wooden Fish",
                Price = 457,
                Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",  
                CategoryId = 5,      
            },
            new ()
            {
                Id = 195,
                Title = "Handmade Plastic Pants",
                Price = 990,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 4,      
            },
            new ()
            {
                Id = 196,
                Title = "Incredible Cotton Car",
                Price = 585,
                Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 197,
                Title = "Rustic Concrete Chips",
                Price = 216,
                Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",  
                CategoryId = 2,      
            },
            new ()
            {
                Id = 198,
                Title = "Fantastic Concrete Cheese",
                Price = 758,
                Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",  
                CategoryId = 1,      
            },
            new ()
            {
                Id = 199,
                Title = "Fantastic Fresh Tuna",
                Price = 820,
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",  
                CategoryId = 3,      
            },
            new ()
            {
                Id = 200,
                Title = "Refined Frozen Fish",
                Price = 217,
                Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",  
                CategoryId = 1,      
            }
        };
        
        modelBuilder.Entity<Product>(product =>
        {
            product.ToTable("Product");
            product.HasKey(p => p.Id);
            product.Property(p => p.Id).UseIdentityColumn();
            product.Property(p => p.Title).IsRequired().HasMaxLength(150);
            product.Property(p => p.Description).IsRequired(false);
            // TODO: Try if taking out the IsRequired() works
            product.HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId);
            product.HasData(productsInit);
        });

        var imagesInit = new List<Image>()
        {
            new()
            {
                Id = 1,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 1,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 2,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 2,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 3,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 3,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 4,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 4,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 5,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 5,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 6,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 6,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 7,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 7,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 8,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 8,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 9,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 9,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 10,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 10,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 11,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 11,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 12,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 12,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 13,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 13,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 14,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 14,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 15,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 15,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 16,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 16,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 17,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 17,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 18,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 18,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 19,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 19,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 20,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 20,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 21,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 21,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 22,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 22,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 23,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 23,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 24,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 24,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 25,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 25,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 26,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 26,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 27,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 27,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 28,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 28,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 29,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 29,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 30,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 30,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 31,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 31,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 32,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 32,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 33,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 33,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 34,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 34,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 35,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 35,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 36,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 36,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 37,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 37,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 38,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 38,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 39,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 39,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 40,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 40,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 41,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 41,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 42,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 42,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 43,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 43,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 44,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 44,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 45,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 45,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 46,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 46,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 47,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 47,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 48,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 48,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 49,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 49,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 50,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 50,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 51,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 51,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 52,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 52,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 53,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 53,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 54,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 54,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 55,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 55,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 56,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 56,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 57,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 57,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 58,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 58,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 59,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 59,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 60,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 60,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 61,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 61,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 62,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 62,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 63,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 63,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 64,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 64,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 65,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 65,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 66,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 66,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 67,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 67,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 68,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 68,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 69,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 69,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 70,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 70,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 71,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 71,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 72,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 72,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 73,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 73,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 74,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 74,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 75,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 75,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 76,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 76,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 77,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 77,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 78,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 78,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 79,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 79,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 80,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 80,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 81,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 81,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 82,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 82,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 83,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 83,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 84,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 84,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 85,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 85,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 86,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 86,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 87,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 87,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 88,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 88,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 89,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 89,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 90,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 90,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 91,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 91,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 92,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 92,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 93,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 93,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 94,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 94,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 95,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 95,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 96,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 96,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 97,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 97,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 98,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 98,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 99,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 99,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 100,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 100,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 101,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 101,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 102,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 102,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 103,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 103,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 104,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 104,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 105,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 105,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 106,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 106,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 107,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 107,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 108,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 108,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 109,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 109,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 110,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 110,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 111,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 111,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 112,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 112,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 113,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 113,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 114,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 114,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 115,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 115,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 116,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 116,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 117,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 117,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 118,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 118,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 119,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 119,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 120,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 120,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 121,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 121,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 122,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 122,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 123,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 123,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 124,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 124,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 125,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 125,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 126,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 126,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 127,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 127,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 128,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 128,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 129,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 129,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 130,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 130,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 131,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 131,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 132,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 132,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 133,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 133,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 134,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 134,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 135,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 135,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 136,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 136,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 137,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 137,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 138,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 138,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 139,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 139,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 140,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 140,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 141,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 141,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 142,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 142,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 143,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 143,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 144,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 144,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 145,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 145,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 146,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 146,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 147,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 147,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 148,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 148,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 149,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 149,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 150,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 150,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 151,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 151,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 152,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 152,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 153,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 153,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 154,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 154,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 155,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 155,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 156,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 156,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 157,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 157,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 158,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 158,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 159,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 159,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 160,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 160,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 161,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 161,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 162,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 162,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 163,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 163,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 164,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 164,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 165,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 165,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 166,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 166,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 167,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 167,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 168,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 168,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 169,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 169,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 170,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 170,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 171,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 171,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 172,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 172,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 173,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 173,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 174,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 174,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 175,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 175,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 176,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 176,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 177,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 177,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 178,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 178,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 179,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 179,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 180,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 180,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 181,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 181,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 182,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 182,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 183,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 183,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 184,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 184,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 185,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 185,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 186,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 186,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 187,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 187,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 188,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 188,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 189,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 189,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 190,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 190,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 191,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 191,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 192,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 192,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 193,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 193,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 194,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 194,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 195,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 195,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 196,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 196,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 197,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 197,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 198,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 198,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 199,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 199,
                Alt = "Mr. Robot"
            },
            new()
            {
                Id = 200,
                Url = "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg",
                ProductId = 200,
                Alt = "Mr. Robot"
            },
                
        };

        modelBuilder.Entity<Image>(image =>
        {
            image.ToTable("Image");
            image.HasKey(p => p.Id);
            image.Property(p => p.Id).UseIdentityColumn();
            image.Property(p => p.Url).IsRequired();
            image.Property(p => p.Alt).IsRequired(false);
            image.HasOne(p => p.Product)
                .WithMany(p => p.Images)
                .HasForeignKey(p => p.ProductId);
            image.HasData(imagesInit);
        });

        #endregion
    }
}