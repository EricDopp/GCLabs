using Microsoft.EntityFrameworkCore;

namespace AdoptionMVC.Models.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Animals> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Animals>().HasData(
    new Animals { ID = 1, img = "https://images.pexels.com/photos/332612/pexels-photo-332612.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", name = "Buddy", description = "Friendly and playful dog", breed = "Labrador Retriever", age = 3 },
    new Animals { ID = 2, img = "https://images.pexels.com/photos/7445032/pexels-photo-7445032.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", name = "Mittens", description = "Cuddly and affectionate cat", breed = "Persian", age = 2 },
    new Animals { ID = 3, img = "https://images.pexels.com/photos/2253275/pexels-photo-2253275.jpeg?auto=compress&cs=tinysrgb&w=300", name = "Max", description = "Loves to go on long walks", breed = "Golden Retriever", age = 4 },
    new Animals { ID = 4, img = "https://images.pexels.com/photos/1294062/pexels-photo-1294062.jpeg?auto=compress&cs=tinysrgb&w=300", name = "Spike", description = "Energetic and adventurous dog", breed = "Boxer", age = 2 },
    new Animals { ID = 5, img = "https://images.pexels.com/photos/7940675/pexels-photo-7940675.jpeg?auto=compress&cs=tinysrgb&w=300", name = "Whiskers", description = "Independent and curious cat", breed = "Siamese", age = 1 },
    new Animals { ID = 6, img = "https://images.pexels.com/photos/8942602/pexels-photo-8942602.jpeg?auto=compress&cs=tinysrgb&w=300", name = "Oliver", description = "Loves to be spoiled with treats", breed = "Maine Coon", age = 5 },
    new Animals { ID = 7, img = "https://images.pexels.com/photos/1741235/pexels-photo-1741235.jpeg?auto=compress&cs=tinysrgb&w=300", name = "Luna", description = "Sweet and gentle dog", breed = "Beagle", age = 3 },
    new Animals { ID = 8, img = "https://images.pexels.com/photos/15802496/pexels-photo-15802496/free-photo-of-portrait-of-a-bengal-cat.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Chloe", description = "Playful and friendly cat", breed = "Bengal", age = 2 },
    new Animals { ID = 9, img = "https://images.pexels.com/photos/12111334/pexels-photo-12111334.jpeg?auto=compress&cs=tinysrgb&w=1600", name = "Rocky", description = "Strong and protective dog", breed = "Rottweiler", age = 4 },
    new Animals { ID = 10, img = "https://images.pexels.com/photos/8369438/pexels-photo-8369438.jpeg?auto=compress&cs=tinysrgb&w=300", name = "Simba", description = "Brave and confident cat", breed = "Siberian", age = 3 },
    new Animals { ID = 11, img = "https://images.pexels.com/photos/169524/pexels-photo-169524.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Milo", description = "Loves to chase after toys", breed = "Dachshund", age = 2 },
    new Animals { ID = 12, img = "https://images.pexels.com/photos/1521306/pexels-photo-1521306.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Lily", description = "Affectionate and loving cat", breed = "British Shorthair", age = 4 },
    new Animals { ID = 13, img = "https://images.pexels.com/photos/3299899/pexels-photo-3299899.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Ruby", description = "Eager to learn new tricks", breed = "Poodle", age = 2 },
    new Animals { ID = 14, img = "https://images.pexels.com/photos/342214/pexels-photo-342214.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Charlie", description = "Loyal and intelligent dog", breed = "German Shepherd", age = 5 },
    new Animals { ID = 15, img = "https://images.pexels.com/photos/6441474/pexels-photo-6441474.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Sophie", description = "Gentle and calm cat", breed = "Ragdoll", age = 3 },
    new Animals { ID = 16, img = "https://images.pexels.com/photos/162193/dog-cavalier-king-charles-spaniel-funny-pet-162193.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Teddy", description = "Loves to snuggle up", breed = "Cavalier King Charles Spaniel", age = 2 },
    new Animals { ID = 17, img = "https://images.pexels.com/photos/3361739/pexels-photo-3361739.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Zoe", description = "Energetic and playful dog", breed = "Shih Tzu", age = 3 },
    new Animals { ID = 18, img = "https://images.pexels.com/photos/141496/pexels-photo-141496.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Lola", description = "Friendly and social cat", breed = "Scottish Fold", age = 2 },
    new Animals { ID = 19, img = "https://images.pexels.com/photos/8601077/pexels-photo-8601077.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Bear", description = "Strong and courageous dog", breed = "Akita", age = 4 },
    new Animals { ID = 20, img = "https://images.pexels.com/photos/13986951/pexels-photo-13986951.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Coco", description = "Loves to explore new places", breed = "Abyssinian", age = 1 },
    new Animals { ID = 21, img = "https://images.pexels.com/photos/18188817/pexels-photo-18188817/free-photo-of-cat-sitting-and-looking-up.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Oscar", description = "Curious and mischievous cat", breed = "Russian Blue", age = 3 },
    new Animals { ID = 22, img = "https://images.pexels.com/photos/191353/pexels-photo-191353.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Mia", description = "Sweet and affectionate dog", breed = "Chihuahua", age = 2 },
    new Animals { ID = 23, img = "https://images.pexels.com/photos/11943120/pexels-photo-11943120.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Leo", description = "Playful and energetic cat", breed = "Oriental Shorthair", age = 1 },
    new Animals { ID = 24, img = "https://images.pexels.com/photos/16669178/pexels-photo-16669178/free-photo-of-shetland-sheepdog-on-the-grass-in-summer.jpeg?auto=compress&cs=tinysrgb&w=600", name = "Rosie", description = "Caring and loving dog", breed = "Shetland Sheepdog", age = 3 }
);

    }
}

/*For the sake of my sanity, here is an SQL query that will recreate my original database albeit with screwy ID numbers because I'm tired :'(

INSERT INTO Animals (img, name, description, breed, age) VALUES
('https://images.pexels.com/photos/332612/pexels-photo-332612.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 'Buddy', 'Friendly and playful dog', 'Labrador Retriever', 3),
('https://images.pexels.com/photos/7445032/pexels-photo-7445032.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 'Mittens', 'Cuddly and affectionate cat', 'Persian', 2),
('https://images.pexels.com/photos/2253275/pexels-photo-2253275.jpeg?auto=compress&cs=tinysrgb&w=300', 'Max', 'Loves to go on long walks', 'Golden Retriever', 4),
('https://images.pexels.com/photos/1294062/pexels-photo-1294062.jpeg?auto=compress&cs=tinysrgb&w=300', 'Spike', 'Energetic and adventurous dog', 'Boxer', 2),
('https://images.pexels.com/photos/7940675/pexels-photo-7940675.jpeg?auto=compress&cs=tinysrgb&w=300', 'Whiskers', 'Independent and curious cat', 'Siamese', 1),
('https://images.pexels.com/photos/8942602/pexels-photo-8942602.jpeg?auto=compress&cs=tinysrgb&w=300', 'Oliver', 'Loves to be spoiled with treats', 'Maine Coon', 5),
('https://images.pexels.com/photos/1741235/pexels-photo-1741235.jpeg?auto=compress&cs=tinysrgb&w=300', 'Luna', 'Sweet and gentle dog', 'Beagle', 3),
('https://images.pexels.com/photos/15802496/pexels-photo-15802496/free-photo-of-portrait-of-a-bengal-cat.jpeg?auto=compress&cs=tinysrgb&w=600', 'Chloe', 'Playful and friendly cat', 'Bengal', 2),
('https://images.pexels.com/photos/12111334/pexels-photo-12111334.jpeg?auto=compress&cs=tinysrgb&w=1600', 'Rocky', 'Strong and protective dog', 'Rottweiler', 4),
('https://images.pexels.com/photos/8369438/pexels-photo-8369438.jpeg?auto=compress&cs=tinysrgb&w=300', 'Simba', 'Brave and confident cat', 'Siberian', 3),
('https://images.pexels.com/photos/169524/pexels-photo-169524.jpeg?auto=compress&cs=tinysrgb&w=600', 'Milo', 'Loves to chase after toys', 'Dachshund', 2),
('https://images.pexels.com/photos/1521306/pexels-photo-1521306.jpeg?auto=compress&cs=tinysrgb&w=600', 'Lily', 'Affectionate and loving cat', 'British Shorthair', 4),
('https://images.pexels.com/photos/3299899/pexels-photo-3299899.jpeg?auto=compress&cs=tinysrgb&w=600', 'Ruby', 'Eager to learn new tricks', 'Poodle', 2),
('https://images.pexels.com/photos/342214/pexels-photo-342214.jpeg?auto=compress&cs=tinysrgb&w=600', 'Charlie', 'Loyal and intelligent dog', 'German Shepherd', 5),
('https://images.pexels.com/photos/6441474/pexels-photo-6441474.jpeg?auto=compress&cs=tinysrgb&w=600', 'Sophie', 'Gentle and calm cat', 'Ragdoll', 3),
('https://images.pexels.com/photos/162193/dog-cavalier-king-charles-spaniel-funny-pet-162193.jpeg?auto=compress&cs=tinysrgb&w=600', 'Teddy', 'Loves to snuggle up', 'Cavalier King Charles Spaniel', 2),
('https://images.pexels.com/photos/3361739/pexels-photo-3361739.jpeg?auto=compress&cs=tinysrgb&w=600', 'Zoe', 'Energetic and playful dog', 'Shih Tzu', 3),
('https://images.pexels.com/photos/141496/pexels-photo-141496.jpeg?auto=compress&cs=tinysrgb&w=600', 'Lola', 'Friendly and social cat', 'Scottish Fold', 2),
('https://images.pexels.com/photos/8601077/pexels-photo-8601077.jpeg?auto=compress&cs=tinysrgb&w=600', 'Bear', 'Strong and courageous dog', 'Akita', 4),
('https://images.pexels.com/photos/13986951/pexels-photo-13986951.jpeg?auto=compress&cs=tinysrgb&w=600', 'Coco', 'Loves to explore new places', 'Abyssinian', 1),
('https://images.pexels.com/photos/18188817/pexels-photo-18188817/free-photo-of-cat-sitting-and-looking-up.jpeg?auto=compress&cs=tinysrgb&w=600', 'Oscar', 'Curious and mischievous cat', 'Russian Blue', 3),
('https://images.pexels.com/photos/191353/pexels-photo-191353.jpeg?auto=compress&cs=tinysrgb&w=600', 'Mia', 'Sweet and affectionate dog', 'Chihuahua', 2),
('https://images.pexels.com/photos/11943120/pexels-photo-11943120.jpeg?auto=compress&cs=tinysrgb&w=600', 'Leo', 'Playful and energetic cat', 'Oriental Shorthair', 1),
('https://images.pexels.com/photos/16669178/pexels-photo-16669178/free-photo-of-shetland-sheepdog-on-the-grass-in-summer.jpeg?auto=compress&cs=tinysrgb&w=600', 'Rosie', 'Caring and loving dog', 'Shetland Sheepdog', 3);
*/