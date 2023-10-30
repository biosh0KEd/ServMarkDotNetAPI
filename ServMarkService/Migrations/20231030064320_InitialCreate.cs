using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServMarkService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TypeImg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "TypeImg" },
                values: new object[,]
                {
                    { 1, "Clothes", "people" },
                    { 2, "Electronics", "tech" },
                    { 3, "Furniture", "arch" },
                    { 4, "Toys", "any" },
                    { 5, "Others", "animals" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 349.0, "Handcrafted Metal Towels" },
                    { 2, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 724.0, "Fantastic Granite Shirt" },
                    { 3, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 834.0, "Gorgeous Soft Shoes" },
                    { 4, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 122.0, "Awesome Wooden Shirt" },
                    { 5, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 690.0, "Small Frozen Ball" },
                    { 6, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 360.0, "Handcrafted Frozen Sausages" },
                    { 7, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 572.0, "Ergonomic Plastic Mouse" },
                    { 8, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 972.0, "Gorgeous Frozen Fish" },
                    { 9, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 547.0, "Gorgeous Cotton Cheese" },
                    { 10, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 806.0, "Fantastic Frozen Pants" },
                    { 11, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 830.0, "Unbranded Fresh Cheese" },
                    { 12, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 306.0, "Ergonomic Cotton Car" },
                    { 13, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 794.0, "Sleek Fresh Keyboard" },
                    { 14, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 223.0, "Handmade Steel Hat" },
                    { 15, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 910.0, "Licensed Concrete Towels" },
                    { 16, 3, "The Football Is Good For Training And Recreational Purposes", 851.0, "Intelligent Wooden Salad" },
                    { 17, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 468.0, "Handmade Granite Tuna" },
                    { 18, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 842.0, "Unbranded Concrete Ball" },
                    { 19, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 524.0, "Rustic Cotton Computer" },
                    { 20, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 401.0, "Rustic Cotton Mouse" },
                    { 21, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 249.0, "Licensed Cotton Salad" },
                    { 22, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 880.0, "Awesome Plastic Shirt" },
                    { 23, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 663.0, "Handcrafted Steel Pizza" },
                    { 24, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 490.0, "Tasty Wooden Pizza" },
                    { 25, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 931.0, "Ergonomic Plastic Chicken" },
                    { 26, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 121.0, "Fantastic Steel Hat" },
                    { 27, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 759.0, "Practical Wooden Keyboard" },
                    { 28, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 997.0, "Tasty Metal Hat" },
                    { 29, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 902.0, "Refined Plastic Tuna" },
                    { 30, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 517.0, "Generic Metal Cheese" },
                    { 31, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 458.0, "Fantastic Concrete Hat" },
                    { 32, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 179.0, "Sleek Wooden Bacon" },
                    { 33, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 142.0, "Intelligent Metal Car" },
                    { 34, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 593.0, "Gorgeous Plastic Soap" },
                    { 35, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 666.0, "Small Fresh Table" },
                    { 36, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 254.0, "Small Granite Car" },
                    { 37, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 459.0, "Small Concrete Hat" },
                    { 38, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 985.0, "Tasty Concrete Car" },
                    { 39, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 740.0, "Ergonomic Cotton Ball" },
                    { 40, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 754.0, "Intelligent Metal Car" },
                    { 41, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 675.0, "Ergonomic Fresh Table" },
                    { 42, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 412.0, "Sleek Soft Chicken" },
                    { 43, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 911.0, "Generic Soft Chips" },
                    { 44, 5, "The Football Is Good For Training And Recreational Purposes", 468.0, "Handcrafted Metal Soap" },
                    { 45, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 994.0, "Ergonomic Rubber Cheese" },
                    { 46, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 883.0, "Generic Metal Bike" },
                    { 47, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 981.0, "Gorgeous Wooden Hat" },
                    { 48, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 201.0, "Ergonomic Wooden Hat" },
                    { 49, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 814.0, "Generic Metal Chair" },
                    { 50, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 622.0, "Refined Wooden Car" },
                    { 51, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 581.0, "Fantastic Granite Chicken" },
                    { 52, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 392.0, "Tasty Metal Bacon" },
                    { 53, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 516.0, "Small Plastic Bacon" },
                    { 54, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 305.0, "Practical Plastic Shirt" },
                    { 55, 2, "The Football Is Good For Training And Recreational Purposes", 677.0, "Gorgeous Wooden Computer" },
                    { 56, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 864.0, "Generic Rubber Tuna" },
                    { 57, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 989.0, "Rustic Concrete Car" },
                    { 58, 2, "The Football Is Good For Training And Recreational Purposes", 787.0, "Handmade Concrete Hat" },
                    { 59, 3, "The Football Is Good For Training And Recreational Purposes", 748.0, "Rustic Soft Bacon" },
                    { 60, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 905.0, "Small Fresh Tuna" },
                    { 61, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 298.0, "Small Fresh Bacon" },
                    { 62, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 815.0, "Incredible Steel Ball" },
                    { 63, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 76.0, "Rustic Granite Table" },
                    { 64, 3, "The Football Is Good For Training And Recreational Purposes", 744.0, "Ergonomic Plastic Pants" },
                    { 65, 2, "The Football Is Good For Training And Recreational Purposes", 739.0, "Small Soft Tuna" },
                    { 66, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 486.0, "Generic Granite Chair" },
                    { 67, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 384.0, "Gorgeous Steel Car" },
                    { 68, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 818.0, "Small Fresh Gloves" },
                    { 69, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 34.0, "Rustic Frozen Soap" },
                    { 70, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 899.0, "Gorgeous Soft Salad" },
                    { 71, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 806.0, "Fantastic Concrete Chair" },
                    { 72, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 481.0, "Handmade Metal Gloves" },
                    { 73, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 525.0, "Sleek Wooden Ball" },
                    { 74, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 192.0, "Generic Plastic Fish" },
                    { 75, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 98.0, "Unbranded Frozen Keyboard" },
                    { 76, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 943.0, "Licensed Fresh Soap" },
                    { 77, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 235.0, "Handmade Granite Mouse" },
                    { 78, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 887.0, "Refined Steel Keyboard" },
                    { 79, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 184.0, "Refined Soft Hat" },
                    { 80, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 203.0, "Small Fresh Sausages" },
                    { 81, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 331.0, "Handmade Cotton Tuna" },
                    { 82, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 23.0, "Intelligent Granite Chair" },
                    { 83, 5, "The Football Is Good For Training And Recreational Purposes", 947.0, "Handmade Concrete Table" },
                    { 84, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2.0, "Awesome Plastic Chicken" },
                    { 85, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 112.0, "Ergonomic Cotton Gloves" },
                    { 86, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 474.0, "Awesome Steel Gloves" },
                    { 87, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 662.0, "Rustic Soft Tuna" },
                    { 88, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 571.0, "Handmade Wooden Chicken" },
                    { 89, 2, "The Football Is Good For Training And Recreational Purposes", 249.0, "Fantastic Granite Pants" },
                    { 90, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 636.0, "Refined Concrete Gloves" },
                    { 91, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 891.0, "Practical Wooden Gloves" },
                    { 92, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 54.0, "Gorgeous Cotton Towels" },
                    { 93, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 893.0, "Intelligent Metal Towels" },
                    { 94, 5, "The Football Is Good For Training And Recreational Purposes", 218.0, "Incredible Fresh Car" },
                    { 95, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 525.0, "Unbranded Steel Sausages" },
                    { 96, 2, "The Football Is Good For Training And Recreational Purposes", 193.0, "Sleek Steel Bike" },
                    { 97, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 410.0, "Awesome Metal Sausages" },
                    { 98, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 251.0, "Gorgeous Frozen Chips" },
                    { 99, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 681.0, "Licensed Wooden Sausages" },
                    { 100, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 415.0, "Ergonomic Rubber Ball" },
                    { 101, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 264.0, "Handcrafted Rubber Sausages" },
                    { 102, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 547.0, "Sleek Cotton Chair" },
                    { 103, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 866.0, "Rustic Frozen Pants" },
                    { 104, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 801.0, "Tasty Steel Car" },
                    { 105, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 511.0, "Awesome Rubber Chair" },
                    { 106, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 714.0, "Tasty Rubber Cheese" },
                    { 107, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 685.0, "Gorgeous Cotton Computer" },
                    { 108, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 466.0, "Ergonomic Soft Tuna" },
                    { 109, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 602.0, "Handcrafted Wooden Gloves" },
                    { 110, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 272.0, "Awesome Steel Chips" },
                    { 111, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 227.0, "Tasty Granite Table" },
                    { 112, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 345.0, "Practical Frozen Keyboard" },
                    { 113, 2, "The Football Is Good For Training And Recreational Purposes", 320.0, "Practical Granite Pizza" },
                    { 114, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 784.0, "Handmade Metal Mouse" },
                    { 115, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 329.0, "Refined Wooden Car" },
                    { 116, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 161.0, "Practical Wooden Bike" },
                    { 117, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 694.0, "Handmade Rubber Towels" },
                    { 118, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 802.0, "Generic Fresh Chicken" },
                    { 119, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 658.0, "Small Granite Bacon" },
                    { 120, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 241.0, "Rustic Wooden Pants" },
                    { 121, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 113.0, "Generic Plastic Bike" },
                    { 122, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 297.0, "Rustic Rubber Towels" },
                    { 123, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 654.0, "Handcrafted Metal Chips" },
                    { 124, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 674.0, "Refined Soft Towels" },
                    { 125, 3, "The Football Is Good For Training And Recreational Purposes", 838.0, "Generic Granite Cheese" },
                    { 126, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 82.0, "Handcrafted Wooden Salad" },
                    { 127, 2, "The Football Is Good For Training And Recreational Purposes", 535.0, "Generic Wooden Car" },
                    { 128, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 488.0, "Incredible Steel Bike" },
                    { 129, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 725.0, "Refined Wooden Sausages" },
                    { 130, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 591.0, "Small Cotton Chicken" },
                    { 131, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 319.0, "Small Frozen Ball" },
                    { 132, 2, "The Football Is Good For Training And Recreational Purposes", 572.0, "Handcrafted Concrete Ball" },
                    { 133, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 945.0, "Refined Steel Tuna" },
                    { 134, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 933.0, "Intelligent Soft Fish" },
                    { 135, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 628.0, "Incredible Steel Pizza" },
                    { 136, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 61.0, "Gorgeous Cotton Keyboard" },
                    { 137, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 550.0, "Awesome Steel Ball" },
                    { 138, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 947.0, "Licensed Steel Shoes" },
                    { 139, 2, "The Football Is Good For Training And Recreational Purposes", 1.0, "Practical Fresh Car" },
                    { 140, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 583.0, "Gorgeous Soft Shirt" },
                    { 141, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 835.0, "Practical Soft Chicken" },
                    { 142, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 999.0, "Refined Wooden Car" },
                    { 143, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 229.0, "Awesome Plastic Mouse" },
                    { 144, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 761.0, "Gorgeous Rubber Bacon" },
                    { 145, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 640.0, "Fantastic Wooden Pants" },
                    { 146, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 74.0, "Awesome Plastic Bike" },
                    { 147, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 976.0, "Generic Cotton Fish" },
                    { 148, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 134.0, "Ergonomic Concrete Keyboard" },
                    { 149, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 831.0, "Licensed Frozen Ball" },
                    { 150, 2, "The Football Is Good For Training And Recreational Purposes", 278.0, "Handcrafted Steel Bacon" },
                    { 151, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 495.0, "Small Cotton Fish" },
                    { 152, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 814.0, "Generic Plastic Salad" },
                    { 153, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 656.0, "Tasty Steel Shirt" },
                    { 154, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 177.0, "Ergonomic Rubber Bacon" },
                    { 155, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 493.0, "Handmade Fresh Car" },
                    { 156, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 823.0, "Incredible Metal Ball" },
                    { 157, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 731.0, "Intelligent Concrete Bike" },
                    { 158, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 81.0, "Handmade Steel Car" },
                    { 159, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 550.0, "Generic Steel Hat" },
                    { 160, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 807.0, "Unbranded Granite Ball" },
                    { 161, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 798.0, "Licensed Metal Table" },
                    { 162, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 632.0, "Handcrafted Fresh Ball" },
                    { 163, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 527.0, "Practical Steel Salad" },
                    { 164, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2.0, "Small Rubber Pizza" },
                    { 165, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 951.0, "Handmade Steel Cheese" },
                    { 166, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 804.0, "Generic Granite Bacon" },
                    { 167, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 266.0, "Intelligent Metal Pizza" },
                    { 168, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 369.0, "Intelligent Fresh Bike" },
                    { 169, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 702.0, "Fantastic Concrete Chair" },
                    { 170, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 91.0, "Small Fresh Soap" },
                    { 171, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 958.0, "Licensed Soft Soap" },
                    { 172, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 867.0, "Awesome Metal Ball" },
                    { 173, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 626.0, "Incredible Soft Hat" },
                    { 174, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 184.0, "Handcrafted Soft Tuna" },
                    { 175, 5, "The Football Is Good For Training And Recreational Purposes", 140.0, "Licensed Concrete Pizza" },
                    { 176, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 590.0, "Generic Soft Gloves" },
                    { 177, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 446.0, "Tasty Plastic Bike" },
                    { 178, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 16.0, "Licensed Rubber Towels" },
                    { 179, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 574.0, "Small Frozen Fish" },
                    { 180, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 55.0, "Intelligent Metal Ball" },
                    { 181, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 792.0, "Practical Soft Bacon" },
                    { 182, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 882.0, "Handcrafted Soft Car" },
                    { 183, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 901.0, "Generic Cotton Fish" },
                    { 184, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 37.0, "Intelligent Granite Towels" },
                    { 185, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 170.0, "Small Rubber Chicken" },
                    { 186, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 480.0, "Generic Fresh Sausages" },
                    { 187, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 555.0, "Ergonomic Concrete Bike" },
                    { 188, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 800.0, "Generic Fresh Computer" },
                    { 189, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 34.0, "Rustic Metal Pizza" },
                    { 190, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 410.0, "Generic Steel Tuna" },
                    { 191, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 521.0, "Licensed Frozen Shoes" },
                    { 192, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 588.0, "Ergonomic Frozen Chips" },
                    { 193, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 937.0, "Tasty Fresh Pants" },
                    { 194, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 457.0, "Small Wooden Fish" },
                    { 195, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 990.0, "Handmade Plastic Pants" },
                    { 196, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 585.0, "Incredible Cotton Car" },
                    { 197, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 216.0, "Rustic Concrete Chips" },
                    { 198, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 758.0, "Fantastic Concrete Cheese" },
                    { 199, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 820.0, "Fantastic Fresh Tuna" },
                    { 200, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 217.0, "Refined Frozen Fish" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
