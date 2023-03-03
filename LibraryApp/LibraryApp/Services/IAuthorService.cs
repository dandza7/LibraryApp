using LibraryApp.Models;
using LibraryApp.Models.DTO;
using LibraryApp.Models.DTO.PFS;

namespace LibraryApp.Services
{
    public interface IAuthorService
    {
        PaginationResponseWrapper<Author> GetAll(PaginationQueryDTO paginationQueryDTO);
        Task<Author?> GetById(long id);
        Task<long> CreateAuthor(Author author);
        Task<Author?> Update(UpdateAuthorDTO updateAuthorDTO);
        Task<IEnumerable<Book>> GetAuthorsBooks(long authorId);
        Task DeleteAuthor(long id);
        bool IsThereAuthorWithId(long id);
    }
}
