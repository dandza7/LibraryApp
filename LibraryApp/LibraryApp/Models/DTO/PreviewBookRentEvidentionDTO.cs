namespace LibraryApp.Models.DTO
{
    public class PreviewBookRentEvidentionDTO
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; }
    }
}
