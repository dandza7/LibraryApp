using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IGenericRepository<User> _userRepository;
        private IGenericRepository<Book> _bookRepository;
        private IGenericRepository<Author> _authorRepository;
        private IGenericRepository<RentedBook> _rentedBookRepository;

        public UnitOfWork(DbContext LibraryDbContext)
        {
            this._libraryDbContext = LibraryDbContext;
        }

        private DbContext _libraryDbContext;

        public IGenericRepository<User> UserRepository
        {
            get
            {
                _userRepository ??= new GenericRepository<User>(_libraryDbContext);
                return _userRepository;
            }
        }

        public IGenericRepository<Book> BookRepository
        {
            get
            {
                _bookRepository ??= new GenericRepository<Book>(_libraryDbContext);
                return _bookRepository;
            }
        }

        public IGenericRepository<Author> AuthorRepository
        {
            get
            {
                _authorRepository ??= new GenericRepository<Author>(_libraryDbContext);
                return _authorRepository;
            }
        }

        public IGenericRepository<RentedBook> RentedBookRepository
        {
            get
            {
                _rentedBookRepository ??= new GenericRepository<RentedBook>(_libraryDbContext);
                return _rentedBookRepository;
            }
        }

        public async Task SaveChangesAsync()
        {
            await _libraryDbContext.SaveChangesAsync();
        }
    }
}
