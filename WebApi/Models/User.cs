using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        
        public required string Name { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }

    }
}