using LibraryApp.Models;
using LibraryApp.Models.DTO;

namespace LibraryApp.SupportClasses.JWTGenerator
{
    public interface IJWTGenerator
    {
        LogInResponseDTO GenerateToken(User user);
    }
}
