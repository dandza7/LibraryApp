namespace LibraryApp.Models.DTO
{
    public class PreviewBookRentHistoryDTO
    {
        public PreviewBookDTO PreviewBook { get; set; } = new PreviewBookDTO();
        public List<PreviewUserRentEvidentionDTO> RentEvidentions { get; set; } = new List<PreviewUserRentEvidentionDTO>();
    }
}
