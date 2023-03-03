using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    public class Author : IEntity
    {
        public Author(string? firstName, string? lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            IsDeleted = false;
        }

        public long Id { get; set; }
        [MaxLength(100)]
        public string? FirstName { get; set; }
        [MaxLength(100)]
        public string? LastName { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
