using LibraryApp.Models;
using LibraryApp.Models.DTO;
using LibraryApp.Models.DTO.PFS;
using LibraryApp.Repositories;
using LibraryApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using System.Linq.Expressions;

namespace LibraryApp.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<long> CreateAuthor(Author author)
        {
            var createdAuthor = await _unitOfWork.AuthorRepository.Create(author);
            await _unitOfWork.SaveChangesAsync();
            return createdAuthor.Id;
        }

        public async Task DeleteAuthor(long id)
        {
            Author author = await GetAuthorById(id, author => author.Books);
            author.Books.Clear();
            _unitOfWork.AuthorRepository.Delete(author);
            await _unitOfWork.SaveChangesAsync();
        }

        public PaginationResponseWrapper<Author> GetAll(PaginationQueryDTO paginationQueryDTO)
        {
            return _unitOfWork.AuthorRepository.Filter(paginationQueryDTO);
        }

        public async Task<IEnumerable<Book>> GetAuthorsBooks(long authorId)
        {
            Author? author = await GetAuthorById(authorId, author => author.Books);
            return author.Books;
        }

        public async Task<Author?> GetById(long id)
        {
            Author? author = await GetAuthorById(id);
            return author;
        }

        public async Task<Author?> Update(UpdateAuthorDTO updateAuthorDTO)
        {
            Author author = await _unitOfWork.AuthorRepository.GetById(updateAuthorDTO.Id);
            author.FirstName = updateAuthorDTO.FirstName;
            author.LastName = updateAuthorDTO.LastName;
            _unitOfWork.AuthorRepository.Update(author);
            await _unitOfWork.SaveChangesAsync();
            return author;
        }

        public bool IsThereAuthorWithId(long id)
        {
            Author? author = _unitOfWork.AuthorRepository.GetAll().Where(author => author.Id == id).FirstOrDefault();
            return author != null;
        }

        private async Task<Author> GetAuthorById(long id, params Expression<Func<Author, object>>[] includes)
        {
            Author? author = await _unitOfWork.AuthorRepository.GetById(id, includes);
            if (author == null)
            {
                throw new NotFoundException("Author with sent ID " + id + " does not exist!");
            }
            return author;
        }
    }
}
