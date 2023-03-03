using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApp.Models
{
    public class User : IEntity
    {
        public User(string? firstName, string? lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            IsDeleted = false;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [MaxLength(100)]
        public string? FirstName { get; set; }
        [MaxLength(100)]
        public string? LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [MaxLength(10)]
        public string Role { get; set; }
        public byte[]? Avatar { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
        [Required]
        public byte[] Salt { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public ICollection<RentedBook> RentedBooks { get; set; } = new List<RentedBook>();
    }
}
