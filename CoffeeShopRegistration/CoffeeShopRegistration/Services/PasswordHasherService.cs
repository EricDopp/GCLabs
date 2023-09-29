using System.Security.Cryptography;
using System.Text;

namespace CoffeeShopRegistration.Services;

public class PasswordHasherService
{
    public string HashPassword(string password, out string salt)
    {
        // Generate a random salt
        byte[] saltBytes = GenerateSalt();
        salt = Convert.ToBase64String(saltBytes);

        // Hash the password with the salt
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
        byte[] saltedPasswordBytes = new byte[passwordBytes.Length + saltBytes.Length];
        Array.Copy(passwordBytes, saltedPasswordBytes, passwordBytes.Length);
        Array.Copy(saltBytes, 0, saltedPasswordBytes, passwordBytes.Length, saltBytes.Length);

        using (var sha256 = SHA256.Create())
        {
            byte[] hashedBytes = sha256.ComputeHash(saltedPasswordBytes);
            return Convert.ToBase64String(hashedBytes);
        }
    }

    private byte[] GenerateSalt()
    {
        byte[] salt = new byte[16]; // You can adjust the salt length as needed
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(salt);
        }
        return salt;
    }

    public bool VerifyPassword(string enteredPassword, string storedPasswordHash, string storedSalt)
    {
        // Convert the salt and password to bytes
        byte[] saltBytes = Convert.FromBase64String(storedSalt);
        byte[] enteredPasswordBytes = Encoding.UTF8.GetBytes(enteredPassword);

        // Concatenate the entered password and stored salt
        byte[] saltedPasswordBytes = new byte[enteredPasswordBytes.Length + saltBytes.Length];
        Array.Copy(enteredPasswordBytes, saltedPasswordBytes, enteredPasswordBytes.Length);
        Array.Copy(saltBytes, 0, saltedPasswordBytes, enteredPasswordBytes.Length, saltBytes.Length);

        // Hash the salted password and compare it with the stored hash
        using (var sha256 = SHA256.Create())
        {
            byte[] hashedBytes = sha256.ComputeHash(saltedPasswordBytes);
            string enteredPasswordHash = Convert.ToBase64String(hashedBytes);
            return string.Equals(enteredPasswordHash, storedPasswordHash);
        }
    }
}
