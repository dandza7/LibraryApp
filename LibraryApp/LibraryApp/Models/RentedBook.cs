using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApp.Models
{
    public class RentedBook : IEntity
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; } = null!;
        [ForeignKey("BookId")]
        public Book Book { get; set; } = null!;
        [Required]
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
