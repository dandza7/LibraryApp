using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    public class Book : IEntity
    {
        public Book(string? name, int quantity)
        {
            Name = name;
            Quantity = quantity;
            IsDeleted = false;
        }

        [Key]
        public long Id { get; set; }
        [MaxLength(250)]
        public string? Name { get; set; }
        public ICollection<Author> Authors { get; set; } = new List<Author>();
        public ICollection<RentedBook> RentedBooks { get; set; } = new List<RentedBook>();
        public byte[]? Cover { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
