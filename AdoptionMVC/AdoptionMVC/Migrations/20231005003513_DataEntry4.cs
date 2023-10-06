using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdoptionMVC.Migrations
{
    /// <inheritdoc />
    public partial class DataEntry4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "ID", "age", "breed", "description", "img", "name" },
                values: new object[,]
                {
                    { 1, 3, "Labrador Retriever", "Friendly and playful dog", "", "Buddy" },
                    { 2, 2, "Persian", "Cuddly and affectionate cat", "", "Mittens" },
                    { 3, 4, "Golden Retriever", "Loves to go on long walks", "", "Max" },
                    { 4, 2, "Boxer", "Energetic and adventurous dog", "", "Spike" },
                    { 5, 1, "Siamese", "Independent and curious cat", "", "Whiskers" },
                    { 6, 5, "Maine Coon", "Loves to be spoiled with treats", "", "Oliver" },
                    { 7, 3, "Beagle", "Sweet and gentle dog", "", "Luna" },
                    { 8, 2, "Bengal", "Playful and friendly cat", "", "Chloe" },
                    { 9, 4, "Rottweiler", "Strong and protective dog", "", "Rocky" },
                    { 10, 3, "Siberian", "Brave and confident cat", "", "Simba" },
                    { 11, 2, "Dachshund", "Loves to chase after toys", "", "Milo" },
                    { 12, 4, "British Shorthair", "Affectionate and loving cat", "", "Lily" },
                    { 13, 2, "Poodle", "Eager to learn new tricks", "", "Ruby" },
                    { 14, 5, "German Shepherd", "Loyal and intelligent dog", "", "Charlie" },
                    { 15, 3, "Ragdoll", "Gentle and calm cat", "", "Sophie" },
                    { 16, 2, "Cavalier King Charles Spaniel", "Loves to snuggle up", "", "Teddy" },
                    { 17, 3, "Shih Tzu", "Energetic and playful dog", "", "Zoe" },
                    { 18, 2, "Scottish Fold", "Friendly and social cat", "", "Lola" },
                    { 19, 4, "Akita", "Strong and courageous dog", "", "Bear" },
                    { 20, 1, "Abyssinian", "Loves to explore new places", "", "Coco" },
                    { 21, 3, "Russian Blue", "Curious and mischievous cat", "", "Oscar" },
                    { 22, 2, "Chihuahua", "Sweet and affectionate dog", "", "Mia" },
                    { 23, 1, "Oriental Shorthair", "Playful and energetic cat", "", "Leo" },
                    { 24, 3, "Shetland Sheepdog", "Caring and loving dog", "", "Rosie" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 24);
        }
    }
}
