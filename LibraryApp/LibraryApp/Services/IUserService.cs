using LibraryApp.Models;
using LibraryApp.Models.DTO;
using LibraryApp.Models.DTO.PFS;

namespace LibraryApp.Services
{
    public interface IUserService
    {
        PaginationResponseWrapper<User> GetAll(PaginationQueryDTO? paginationQueryDTO);
        Task<User?> GetById(long id);
        Task<User?> GetByEmail(string email);
        Task<long> RegisterUser(User user);
        Task<User?> UpgradeUsersRole(long id);
        Task<User?> DowngradeUsersRole(long id);
        User? AuthenticateUser(LogInRequestDTO logInRequestDTO);
        void CheckEmailUniqueness(string email);
        Task<User?> UpdateProfile(string email, UpdateProfileDTO updateProfileDTO);
        Task UpdateAvatar(string email, IFormFile avatar);
        byte[] GetAvatar(string email);
        Task DeleteAvatar(string email);
        Task<PreviewUserRentHistoryDTO> GetUsersRentHistory(long id);
    }
}
