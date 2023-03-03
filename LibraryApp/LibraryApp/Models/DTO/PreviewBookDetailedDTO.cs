namespace LibraryApp.Models.DTO
{
    public class PreviewBookDetailedDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public ICollection<PreviewAuthorDTO> Authors { get; set; } = new List<PreviewAuthorDTO>();
        public int Quantity { get; set; }
        public int Available { get; set; }
    }
}
