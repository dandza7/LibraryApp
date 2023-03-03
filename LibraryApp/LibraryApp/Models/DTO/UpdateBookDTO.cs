namespace LibraryApp.Models.DTO
{
    public class UpdateBookDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
    }
}
