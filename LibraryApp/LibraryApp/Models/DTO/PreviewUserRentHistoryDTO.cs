namespace LibraryApp.Models.DTO
{
    public class PreviewUserRentHistoryDTO
    {
        public PreviewUserDTO PreviewUser { get; set; } = new PreviewUserDTO();
        public List<PreviewBookRentEvidentionDTO> RentEvidentions { get; set; } = new List<PreviewBookRentEvidentionDTO>();
    }
}
