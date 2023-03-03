using LibraryApp.Models;

namespace LibraryApp.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<Book> BookRepository { get; }
        IGenericRepository<Author> AuthorRepository { get; }
        IGenericRepository<RentedBook> RentedBookRepository { get; }
        Task SaveChangesAsync();
    }
}
