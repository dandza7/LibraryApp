using LibraryApp.Models;
using LibraryApp.Models.DTO;
using LibraryApp.Models.DTO.PFS;

namespace LibraryApp.Services
{
    public interface IBookService
    {
        PaginationResponseWrapper<Book> GetAll(PaginationQueryDTO paginationQueryDTO);
        Task<Book?> GetByIdDetailed(long id);
        Task<long> CreateBook(NewBookDTO newBookDTO);
        Task<Book?> UpdateBook(UpdateBookDTO updateBookDTO);
        Task UpdateBookCover(long id, IFormFile cover);
        Task<byte[]> GetBookCover(long id);
        Task DeleteBookCover(long id);
        Task<Book?> AddAuthor(AddBooksAuthorsDTO addBookAuthorsDTO);
        Task<Book?> RemoveAuthor(RemoveBooksAuthorDTO removeBookAuthorsDTO);
        Task DeleteBook(long id);
        Task<PreviewBookRentHistoryDTO> GetBooksRentHistory(long id);
        Task<bool> RentBook(long BookId, string email);
        bool IsThereBookWithId(long id);
    }
}
