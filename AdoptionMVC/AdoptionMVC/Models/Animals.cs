using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdoptionMVC.Models;

public class Animals
{
    public int ID { get; set; }
    [Column(TypeName = "varchar(MAX)")]
    [Required]
    public string img { get; set; }
    [Required]
    public string name { get; set; }
    [Required]
    public string description { get; set; }
    [Required]
    public string breed { get; set; }
    [Required]
    public int age { get; set; }
}
