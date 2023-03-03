using AutoMapper;
using LibraryApp.Models;
using LibraryApp.Models.DTO;
using LibraryApp.Models.DTO.PFS;
using LibraryApp.Repositories;
using LibraryApp.SupportClasses.FileConverter;
using LibraryApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using LibraryApp.SupportClasses.PasswordHasher;
using LibraryApp.SupportClasses.Roles;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IPasswordHasher passwordHasher, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
        }

        public PaginationResponseWrapper<User> GetAll(PaginationQueryDTO? paginationQueryDTO)
        {
            return _unitOfWork.UserRepository.Filter(paginationQueryDTO);
        }

        public async Task<User?> GetById(long id)
        {
            User? user = await _unitOfWork.UserRepository.GetById(id);
            if (user == null)
            {
                throw new NotFoundException("User with sent ID does not exist!");
            }
            return user;
        }

        public async Task<User?> GetByEmail(string email)
        {
            User? user = await _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new NotFoundException("User with sent Email does not exist!");
            }
            return user;
        }

        public async Task<long> RegisterUser(User user)
        {
            user.Role = Roles.User;
            byte[] salt;
            string hashedPassword = _passwordHasher.HashPassword(user.Password, out salt);
            user.Password = hashedPassword;
            user.Salt = salt;
            var createdUser = await _unitOfWork.UserRepository.Create(user);
            await _unitOfWork.SaveChangesAsync();
            return createdUser.Id;
        }
        public async Task<User?> UpgradeUsersRole(long id)
        {
            User? userToUpdate = await _unitOfWork.UserRepository.GetById(id);
            IsUserNull(userToUpdate);
            userToUpdate.Role = Roles.Librarian;
            _unitOfWork.UserRepository.Update(userToUpdate);
            await _unitOfWork.SaveChangesAsync();
            return userToUpdate;
        }

        public async Task<User?> DowngradeUsersRole(long id)
        {
            User? userToUpdate = await _unitOfWork.UserRepository.GetById(id);
            IsUserNull(userToUpdate);
            userToUpdate.Role = Roles.User;
            _unitOfWork.UserRepository.Update(userToUpdate);
            await _unitOfWork.SaveChangesAsync();
            return userToUpdate;
        }

        public User? AuthenticateUser(LogInRequestDTO logInRequestDTO)
        {
            User? user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == logInRequestDTO.Email).FirstOrDefault();
            IsUserNull(user, "email");
            if (_passwordHasher.VerifyPassword(logInRequestDTO.Password, user.Password, user.Salt))
            {
                return user;
            }
            throw new BadCredentialsException();
        }
        public void CheckEmailUniqueness(string email)
        {
            User? user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).FirstOrDefault();
            if (user != null)
            {
                throw new EmailNotUniqueException();
            }
        }

        public async Task<User?> UpdateProfile(string email, UpdateProfileDTO updateProfileDTO)
        {
            User? user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).FirstOrDefault();
            IsUserNull(user, "email");
            user.FirstName = updateProfileDTO.FirstName;
            user.LastName = updateProfileDTO.LastName;
            _unitOfWork.UserRepository.Update(user);
            await _unitOfWork.SaveChangesAsync();
            return user;
        }

        public async Task UpdateAvatar(string email, IFormFile avatar)
        {
            User? user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).FirstOrDefault();
            IsUserNull(user, "email");
            user.Avatar = FileConverter.FormFileToBytes(avatar).Result;
            _unitOfWork.UserRepository.Update(user);
            await _unitOfWork.SaveChangesAsync();
        }
        public byte[] GetAvatar(string email)
        {
            User? user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).FirstOrDefault();
            IsUserNull(user, "email");
            if (user.Avatar == null)
            {
                throw new NoAvatarFoundException();
            }
            return user.Avatar;
        }
        public async Task DeleteAvatar(string email)
        {
            User? user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).FirstOrDefault();
            IsUserNull(user, "email");
            user.Avatar = null;
            _unitOfWork.UserRepository.Update(user);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<PreviewUserRentHistoryDTO> GetUsersRentHistory(long id)
        {
            var rentedBooks = await _unitOfWork.RentedBookRepository.GetAll(rb => rb.User, rb => rb.Book).Where(rb => rb.User.Id == id).ToListAsync();
            if (rentedBooks.Count == 0)
            {
                throw new EmptyCollectionException();
            }
            PreviewUserRentHistoryDTO rentHistory = new PreviewUserRentHistoryDTO();
            rentHistory.PreviewUser = _mapper.Map<PreviewUserDTO>(rentedBooks.First().User);
            foreach (var rent in rentedBooks)
            {
                var evidention = _mapper.Map<PreviewBookRentEvidentionDTO>(rent);
                rentHistory.RentEvidentions.Add(evidention);
            }
            return rentHistory;
        }

        private void IsUserNull(User? user, string key = "ID")
        {
            if (user == null)
            {
                throw new NotFoundException("User with sent " + key + " does not exist!");
            }
        }
    }
}
