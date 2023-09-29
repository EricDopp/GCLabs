using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShopRegistration.Models;

public class User
{
    public int Id { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string UserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
