using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServMarkService.Migrations
{
    /// <inheritdoc />
    public partial class InitialImagesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "Alt", "ProductId", "Url" },
                values: new object[,]
                {
                    { 1, "Mr. Robot", 1, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 2, "Mr. Robot", 2, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 3, "Mr. Robot", 3, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 4, "Mr. Robot", 4, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 5, "Mr. Robot", 5, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 6, "Mr. Robot", 6, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 7, "Mr. Robot", 7, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 8, "Mr. Robot", 8, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 9, "Mr. Robot", 9, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 10, "Mr. Robot", 10, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 11, "Mr. Robot", 11, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 12, "Mr. Robot", 12, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 13, "Mr. Robot", 13, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 14, "Mr. Robot", 14, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 15, "Mr. Robot", 15, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 16, "Mr. Robot", 16, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 17, "Mr. Robot", 17, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 18, "Mr. Robot", 18, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 19, "Mr. Robot", 19, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 20, "Mr. Robot", 20, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 21, "Mr. Robot", 21, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 22, "Mr. Robot", 22, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 23, "Mr. Robot", 23, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 24, "Mr. Robot", 24, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 25, "Mr. Robot", 25, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 26, "Mr. Robot", 26, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 27, "Mr. Robot", 27, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 28, "Mr. Robot", 28, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 29, "Mr. Robot", 29, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 30, "Mr. Robot", 30, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 31, "Mr. Robot", 31, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 32, "Mr. Robot", 32, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 33, "Mr. Robot", 33, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 34, "Mr. Robot", 34, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 35, "Mr. Robot", 35, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 36, "Mr. Robot", 36, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 37, "Mr. Robot", 37, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 38, "Mr. Robot", 38, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 39, "Mr. Robot", 39, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 40, "Mr. Robot", 40, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 41, "Mr. Robot", 41, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 42, "Mr. Robot", 42, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 43, "Mr. Robot", 43, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 44, "Mr. Robot", 44, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 45, "Mr. Robot", 45, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 46, "Mr. Robot", 46, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 47, "Mr. Robot", 47, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 48, "Mr. Robot", 48, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 49, "Mr. Robot", 49, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 50, "Mr. Robot", 50, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 51, "Mr. Robot", 51, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 52, "Mr. Robot", 52, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 53, "Mr. Robot", 53, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 54, "Mr. Robot", 54, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 55, "Mr. Robot", 55, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 56, "Mr. Robot", 56, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 57, "Mr. Robot", 57, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 58, "Mr. Robot", 58, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 59, "Mr. Robot", 59, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 60, "Mr. Robot", 60, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 61, "Mr. Robot", 61, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 62, "Mr. Robot", 62, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 63, "Mr. Robot", 63, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 64, "Mr. Robot", 64, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 65, "Mr. Robot", 65, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 66, "Mr. Robot", 66, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 67, "Mr. Robot", 67, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 68, "Mr. Robot", 68, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 69, "Mr. Robot", 69, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 70, "Mr. Robot", 70, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 71, "Mr. Robot", 71, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 72, "Mr. Robot", 72, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 73, "Mr. Robot", 73, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 74, "Mr. Robot", 74, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 75, "Mr. Robot", 75, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 76, "Mr. Robot", 76, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 77, "Mr. Robot", 77, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 78, "Mr. Robot", 78, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 79, "Mr. Robot", 79, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 80, "Mr. Robot", 80, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 81, "Mr. Robot", 81, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 82, "Mr. Robot", 82, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 83, "Mr. Robot", 83, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 84, "Mr. Robot", 84, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 85, "Mr. Robot", 85, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 86, "Mr. Robot", 86, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 87, "Mr. Robot", 87, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 88, "Mr. Robot", 88, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 89, "Mr. Robot", 89, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 90, "Mr. Robot", 90, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 91, "Mr. Robot", 91, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 92, "Mr. Robot", 92, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 93, "Mr. Robot", 93, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 94, "Mr. Robot", 94, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 95, "Mr. Robot", 95, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 96, "Mr. Robot", 96, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 97, "Mr. Robot", 97, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 98, "Mr. Robot", 98, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 99, "Mr. Robot", 99, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 100, "Mr. Robot", 100, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 101, "Mr. Robot", 101, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 102, "Mr. Robot", 102, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 103, "Mr. Robot", 103, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 104, "Mr. Robot", 104, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 105, "Mr. Robot", 105, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 106, "Mr. Robot", 106, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 107, "Mr. Robot", 107, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 108, "Mr. Robot", 108, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 109, "Mr. Robot", 109, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 110, "Mr. Robot", 110, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 111, "Mr. Robot", 111, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 112, "Mr. Robot", 112, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 113, "Mr. Robot", 113, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 114, "Mr. Robot", 114, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 115, "Mr. Robot", 115, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 116, "Mr. Robot", 116, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 117, "Mr. Robot", 117, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 118, "Mr. Robot", 118, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 119, "Mr. Robot", 119, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 120, "Mr. Robot", 120, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 121, "Mr. Robot", 121, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 122, "Mr. Robot", 122, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 123, "Mr. Robot", 123, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 124, "Mr. Robot", 124, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 125, "Mr. Robot", 125, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 126, "Mr. Robot", 126, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 127, "Mr. Robot", 127, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 128, "Mr. Robot", 128, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 129, "Mr. Robot", 129, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 130, "Mr. Robot", 130, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 131, "Mr. Robot", 131, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 132, "Mr. Robot", 132, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 133, "Mr. Robot", 133, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 134, "Mr. Robot", 134, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 135, "Mr. Robot", 135, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 136, "Mr. Robot", 136, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 137, "Mr. Robot", 137, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 138, "Mr. Robot", 138, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 139, "Mr. Robot", 139, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 140, "Mr. Robot", 140, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 141, "Mr. Robot", 141, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 142, "Mr. Robot", 142, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 143, "Mr. Robot", 143, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 144, "Mr. Robot", 144, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 145, "Mr. Robot", 145, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 146, "Mr. Robot", 146, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 147, "Mr. Robot", 147, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 148, "Mr. Robot", 148, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 149, "Mr. Robot", 149, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 150, "Mr. Robot", 150, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 151, "Mr. Robot", 151, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 152, "Mr. Robot", 152, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 153, "Mr. Robot", 153, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 154, "Mr. Robot", 154, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 155, "Mr. Robot", 155, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 156, "Mr. Robot", 156, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 157, "Mr. Robot", 157, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 158, "Mr. Robot", 158, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 159, "Mr. Robot", 159, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 160, "Mr. Robot", 160, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 161, "Mr. Robot", 161, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 162, "Mr. Robot", 162, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 163, "Mr. Robot", 163, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 164, "Mr. Robot", 164, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 165, "Mr. Robot", 165, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 166, "Mr. Robot", 166, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 167, "Mr. Robot", 167, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 168, "Mr. Robot", 168, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 169, "Mr. Robot", 169, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 170, "Mr. Robot", 170, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 171, "Mr. Robot", 171, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 172, "Mr. Robot", 172, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 173, "Mr. Robot", 173, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 174, "Mr. Robot", 174, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 175, "Mr. Robot", 175, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 176, "Mr. Robot", 176, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 177, "Mr. Robot", 177, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 178, "Mr. Robot", 178, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 179, "Mr. Robot", 179, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 180, "Mr. Robot", 180, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 181, "Mr. Robot", 181, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 182, "Mr. Robot", 182, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 183, "Mr. Robot", 183, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 184, "Mr. Robot", 184, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 185, "Mr. Robot", 185, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 186, "Mr. Robot", 186, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 187, "Mr. Robot", 187, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 188, "Mr. Robot", 188, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 189, "Mr. Robot", 189, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 190, "Mr. Robot", 190, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 191, "Mr. Robot", 191, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 192, "Mr. Robot", 192, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 193, "Mr. Robot", 193, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 194, "Mr. Robot", 194, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 195, "Mr. Robot", 195, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 196, "Mr. Robot", 196, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 197, "Mr. Robot", 197, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 198, "Mr. Robot", 198, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 199, "Mr. Robot", 199, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" },
                    { 200, "Mr. Robot", 200, "https://hdqwalls.com/wallpapers/mr-robot-fan-art-wide.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 200);
        }
    }
}
