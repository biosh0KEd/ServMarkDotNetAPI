using System.ComponentModel.DataAnnotations.Schema;
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
        });

        #endregion
    }
}