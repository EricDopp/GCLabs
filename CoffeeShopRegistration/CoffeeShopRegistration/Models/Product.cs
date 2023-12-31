﻿using CoffeeShopRegistration.Models.Enum;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopRegistration.Models;

public class Product
{
    public int Id { get; set; }
    [Precision(10, 2)]
    public decimal Price { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    public ProductCategory Category { get; set; }
    //enums are stored as integers in the database, so the default is the 0th or first category here
}
