﻿// <auto-generated />
using AdoptionMVC.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdoptionMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231005003700_Buddy")]
    partial class Buddy
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdoptionMVC.Models.Animals", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            age = 3,
                            breed = "Labrador Retriever",
                            description = "Friendly and playful dog",
                            img = "",
                            name = "Buddy"
                        },
                        new
                        {
                            ID = 2,
                            age = 2,
                            breed = "Persian",
                            description = "Cuddly and affectionate cat",
                            img = "",
                            name = "Mittens"
                        },
                        new
                        {
                            ID = 3,
                            age = 4,
                            breed = "Golden Retriever",
                            description = "Loves to go on long walks",
                            img = "",
                            name = "Max"
                        },
                        new
                        {
                            ID = 4,
                            age = 2,
                            breed = "Boxer",
                            description = "Energetic and adventurous dog",
                            img = "",
                            name = "Spike"
                        },
                        new
                        {
                            ID = 5,
                            age = 1,
                            breed = "Siamese",
                            description = "Independent and curious cat",
                            img = "",
                            name = "Whiskers"
                        },
                        new
                        {
                            ID = 6,
                            age = 5,
                            breed = "Maine Coon",
                            description = "Loves to be spoiled with treats",
                            img = "",
                            name = "Oliver"
                        },
                        new
                        {
                            ID = 7,
                            age = 3,
                            breed = "Beagle",
                            description = "Sweet and gentle dog",
                            img = "",
                            name = "Luna"
                        },
                        new
                        {
                            ID = 8,
                            age = 2,
                            breed = "Bengal",
                            description = "Playful and friendly cat",
                            img = "",
                            name = "Chloe"
                        },
                        new
                        {
                            ID = 9,
                            age = 4,
                            breed = "Rottweiler",
                            description = "Strong and protective dog",
                            img = "",
                            name = "Rocky"
                        },
                        new
                        {
                            ID = 10,
                            age = 3,
                            breed = "Siberian",
                            description = "Brave and confident cat",
                            img = "",
                            name = "Simba"
                        },
                        new
                        {
                            ID = 11,
                            age = 2,
                            breed = "Dachshund",
                            description = "Loves to chase after toys",
                            img = "",
                            name = "Milo"
                        },
                        new
                        {
                            ID = 12,
                            age = 4,
                            breed = "British Shorthair",
                            description = "Affectionate and loving cat",
                            img = "",
                            name = "Lily"
                        },
                        new
                        {
                            ID = 13,
                            age = 2,
                            breed = "Poodle",
                            description = "Eager to learn new tricks",
                            img = "",
                            name = "Ruby"
                        },
                        new
                        {
                            ID = 14,
                            age = 5,
                            breed = "German Shepherd",
                            description = "Loyal and intelligent dog",
                            img = "",
                            name = "Charlie"
                        },
                        new
                        {
                            ID = 15,
                            age = 3,
                            breed = "Ragdoll",
                            description = "Gentle and calm cat",
                            img = "",
                            name = "Sophie"
                        },
                        new
                        {
                            ID = 16,
                            age = 2,
                            breed = "Cavalier King Charles Spaniel",
                            description = "Loves to snuggle up",
                            img = "",
                            name = "Teddy"
                        },
                        new
                        {
                            ID = 17,
                            age = 3,
                            breed = "Shih Tzu",
                            description = "Energetic and playful dog",
                            img = "",
                            name = "Zoe"
                        },
                        new
                        {
                            ID = 18,
                            age = 2,
                            breed = "Scottish Fold",
                            description = "Friendly and social cat",
                            img = "",
                            name = "Lola"
                        },
                        new
                        {
                            ID = 19,
                            age = 4,
                            breed = "Akita",
                            description = "Strong and courageous dog",
                            img = "",
                            name = "Bear"
                        },
                        new
                        {
                            ID = 20,
                            age = 1,
                            breed = "Abyssinian",
                            description = "Loves to explore new places",
                            img = "",
                            name = "Coco"
                        },
                        new
                        {
                            ID = 21,
                            age = 3,
                            breed = "Russian Blue",
                            description = "Curious and mischievous cat",
                            img = "",
                            name = "Oscar"
                        },
                        new
                        {
                            ID = 22,
                            age = 2,
                            breed = "Chihuahua",
                            description = "Sweet and affectionate dog",
                            img = "",
                            name = "Mia"
                        },
                        new
                        {
                            ID = 23,
                            age = 1,
                            breed = "Oriental Shorthair",
                            description = "Playful and energetic cat",
                            img = "",
                            name = "Leo"
                        },
                        new
                        {
                            ID = 24,
                            age = 3,
                            breed = "Shetland Sheepdog",
                            description = "Caring and loving dog",
                            img = "",
                            name = "Rosie"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
