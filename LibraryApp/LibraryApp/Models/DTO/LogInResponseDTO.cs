namespace LibraryApp.Models.DTO
{
    public class LogInResponseDTO
    {
        public LogInResponseDTO(string token, DateTime expirationDate)
        {
            Token = token;
            ExpirationDate = expirationDate;
        }

        public string Token { get; set; }

        public DateTime ExpirationDate { get; set; }

    }
}
