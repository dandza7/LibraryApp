namespace LibraryApp.Models.DTO
{
    public class PreviewUserDTO
    {
        public PreviewUserDTO() { }

        public PreviewUserDTO(long id, string? firstName, string? lastName, string email, string role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Role = role;
        }
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
