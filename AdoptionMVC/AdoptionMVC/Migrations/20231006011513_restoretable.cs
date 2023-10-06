using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdoptionMVC.Migrations
{
    /// <inheritdoc />
    public partial class restoretable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 9,
                column: "img",
                value: "https://images.pexels.com/photos/12111334/pexels-photo-12111334.jpeg?auto=compress&cs=tinysrgb&w=1600");
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "ID", "img", "name", "description", "breed", "age" },
                values: new object[,]
                {
                    {1,"https://images.pexels.com/photos/332612/pexels-photo-332612.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1","Buddy","Friendly and playful dog","Labrador Retriever",3 },
                    {2,"https://images.pexels.com/photos/7445032/pexels-photo-7445032.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1","Mittens","Cuddly and affectionate cat","Persian",2 },
                    {3,"https://images.pexels.com/photos/2253275/pexels-photo-2253275.jpeg?auto=compress&cs=tinysrgb&w=300","Max","Loves to go on long walks","Golden Retriever",4 },
                    {4,"https://images.pexels.com/photos/1294062/pexels-photo-1294062.jpeg?auto=compress&cs=tinysrgb&w=300","Spike","Energetic and adventurous dog","Boxer",2 },
                    {5,"https://images.pexels.com/photos/7940675/pexels-photo-7940675.jpeg?auto=compress&cs=tinysrgb&w=300","Whiskers","Independent and curious cat","Siamese",1 },
                    {6,"https://images.pexels.com/photos/8942602/pexels-photo-8942602.jpeg?auto=compress&cs=tinysrgb&w=300","Oliver","Loves to be spoiled with treats","Maine Coon",5 },
                    {7,"https://images.pexels.com/photos/1741235/pexels-photo-1741235.jpeg?auto=compress&cs=tinysrgb&w=300","Luna","Sweet and gentle dog","Beagle",3 },
                    {8,"https://images.pexels.com/photos/15802496/pexels-photo-15802496/free-photo-of-portrait-of-a-bengal-cat.jpeg?auto=compress&cs=tinysrgb&w=600","Chloe","Playful and friendly cat","Bengal",2 },
                    {9,"https://images.pexels.com/photos/12111334/pexels-photo-12111334.jpeg?auto=compress&cs=tinysrgb&w=1600","Rocky","Strong and protective dog","Rottweiler",4 },
                    {10,"https://images.pexels.com/photos/8369438/pexels-photo-8369438.jpeg?auto=compress&cs=tinysrgb&w=300","Simba","Brave and confident cat","Siberian",3 },
                    {11,"https://images.pexels.com/photos/169524/pexels-photo-169524.jpeg?auto=compress&cs=tinysrgb&w=600","Milo","Loves to chase after toys","Dachshund",2 },
                    {12,"https://images.pexels.com/photos/1521306/pexels-photo-1521306.jpeg?auto=compress&cs=tinysrgb&w=600","Lily","Affectionate and loving cat","British Shorthair",4 },
                    {13,"https://images.pexels.com/photos/3299899/pexels-photo-3299899.jpeg?auto=compress&cs=tinysrgb&w=600","Ruby","Eager to learn new tricks","Poodle",2 },
                    {14,"https://images.pexels.com/photos/342214/pexels-photo-342214.jpeg?auto=compress&cs=tinysrgb&w=600","Charlie","Loyal and intelligent dog","German Shepherd",5 },
                    {15,"https://images.pexels.com/photos/6441474/pexels-photo-6441474.jpeg?auto=compress&cs=tinysrgb&w=600","Sophie","Gentle and calm cat","Ragdoll",3 },
                    {16,"https://images.pexels.com/photos/162193/dog-cavalier-king-charles-spaniel-funny-pet-162193.jpeg?auto=compress&cs=tinysrgb&w=600","Teddy","Loves to snuggle up","Cavalier King Charles Spaniel",2 },
                    {17,"https://images.pexels.com/photos/3361739/pexels-photo-3361739.jpeg?auto=compress&cs=tinysrgb&w=600","Zoe","Energetic and playful dog","Shih Tzu",3 },
                    {18,"https://images.pexels.com/photos/141496/pexels-photo-141496.jpeg?auto=compress&cs=tinysrgb&w=600","Lola","Friendly and social cat","Scottish Fold",2 },
                    {19,"https://images.pexels.com/photos/8601077/pexels-photo-8601077.jpeg?auto=compress&cs=tinysrgb&w=600","Bear","Strong and courageous dog","Akita",4 },
                    {20,"https://images.pexels.com/photos/13986951/pexels-photo-13986951.jpeg?auto=compress&cs=tinysrgb&w=600","Coco","Loves to explore new places","Abyssinian",1 },
                    {21,"https://images.pexels.com/photos/18188817/pexels-photo-18188817/free-photo-of-cat-sitting-and-looking-up.jpeg?auto=compress&cs=tinysrgb&w=600","Oscar","Curious and mischievous cat","Russian Blue",3 },
                    {22,"https://images.pexels.com/photos/191353/pexels-photo-191353.jpeg?auto=compress&cs=tinysrgb&w=600","Mia","Sweet and affectionate dog","Chihuahua",2 },
                    {23,"https://images.pexels.com/photos/11943120/pexels-photo-11943120.jpeg?auto=compress&cs=tinysrgb&w=600","Leo","Playful and energetic cat","Oriental Shorthair",1 },
                    {24,"https://images.pexels.com/photos/16669178/pexels-photo-16669178/free-photo-of-shetland-sheepdog-on-the-grass-in-summer.jpeg?auto=compress&cs=tinysrgb&w=600","Rosie","Caring and loving dog","Shetland Sheepdog",3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 9,
                column: "img",
                value: "https://images.pexels.com/photos/7352686/pexels-photo-7352686.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1");
        }
    }
}
