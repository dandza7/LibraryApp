using AutoMapper;
using LibraryApp.Models;
using LibraryApp.Models.DTO;
using LibraryApp.Models.DTO.PFS;
using LibraryApp.Repositories;
using LibraryApp.SupportClasses.FileConverter;
using LibraryApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LibraryApp.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BookService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public PaginationResponseWrapper<Book> GetAll(PaginationQueryDTO paginationQueryDTO)
        {
            return _unitOfWork.BookRepository.Filter(paginationQueryDTO);
        }

        public async Task<long> CreateBook(NewBookDTO newBookDTO)
        {
            List<Author> authorList = new List<Author>();
            Book book = new Book(newBookDTO.Name, newBookDTO.Quantity);
            book.Authors = authorList;
            await _unitOfWork.BookRepository.Create(book);
            await _unitOfWork.SaveChangesAsync();
            return book.Id;
        }

        public async Task<Book?> GetByIdDetailed(long id)
        {
            Book book = await GetBookById(id, book => book.Authors, book => book.RentedBooks);
            return book;
        }

        public async Task<Book?> AddAuthor(AddBooksAuthorsDTO addBooksAuthorsDTO)
        {
            Book book = await _unitOfWork.BookRepository.GetById(addBooksAuthorsDTO.BookId, book => book.Authors);
            Author author = await _unitOfWork.AuthorRepository.GetById(addBooksAuthorsDTO.AuthorId);
            book.Authors.Add(author);
            Book updatedBook = _unitOfWork.BookRepository.Update(book);
            await _unitOfWork.SaveChangesAsync();
            return updatedBook;
        }

        public async Task<Book?> RemoveAuthor(RemoveBooksAuthorDTO removeBooksAuthorsDTO)
        {
            Book book = await _unitOfWork.BookRepository.GetById(removeBooksAuthorsDTO.BookId, book => book.Authors);
            Author author = await _unitOfWork.AuthorRepository.GetById(removeBooksAuthorsDTO.AuthorId);
            if (author != null)
            {
                book.Authors.Remove(author);
                Book updatedBook = _unitOfWork.BookRepository.Update(book);
                await _unitOfWork.SaveChangesAsync();
                return updatedBook;
            }
            return book;
        }

        public async Task DeleteBook(long id)
        {
            Book book = await GetBookById(id, book => book.Authors);
            book.Authors.Clear();
            _unitOfWork.BookRepository.Delete(book);
            await _unitOfWork.SaveChangesAsync();

        }

        public async Task<Book?> UpdateBook(UpdateBookDTO updateBookDTO)
        {
            Book book = await _unitOfWork.BookRepository.GetById(updateBookDTO.Id);
            book.Name = updateBookDTO.Name;
            book.Quantity = updateBookDTO.Quantity;
            await _unitOfWork.SaveChangesAsync();
            return book;
        }

        public bool IsThereBookWithId(long id)
        {
            Book? book = _unitOfWork.BookRepository.GetAll().Where(book => book.Id == id).FirstOrDefault();
            return book != null;
        }

        public async Task UpdateBookCover(long id, IFormFile cover)
        {
            Book? book = await GetBookById(id);
            book.Cover = FileConverter.FormFileToBytes(cover).Result;
            _unitOfWork.BookRepository.Update(book);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<byte[]> GetBookCover(long id)
        {
            Book? book = await GetBookById(id);
            if (book.Cover == null)
            {
                throw new NoAvatarFoundException();
            }
            return book.Cover;
        }

        public async Task DeleteBookCover(long id)
        {
            Book? book = await GetBookById(id);
            book.Cover = null;
            _unitOfWork.BookRepository.Update(book);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<PreviewBookRentHistoryDTO> GetBooksRentHistory(long id)
        {
            var rentedBooks = await _unitOfWork.RentedBookRepository.GetAll(rb => rb.User, rb => rb.Book).Where(rb => rb.Book.Id == id).ToListAsync();
            if (rentedBooks.Count == 0)
            {
                throw new EmptyCollectionException();
            }
            PreviewBookRentHistoryDTO rentHistory = new PreviewBookRentHistoryDTO();
            rentHistory.PreviewBook = _mapper.Map<PreviewBookDTO>(rentedBooks.First().Book);
            foreach (var rent in rentedBooks)
            {
                var evidention = _mapper.Map<PreviewUserRentEvidentionDTO>(rent);
                rentHistory.RentEvidentions.Add(evidention);
            }
            return rentHistory;
        }

        private async Task<Book> GetBookById(long id, params Expression<Func<Book, object>>[] includes)
        {
            Book? book = await _unitOfWork.BookRepository.GetById(id, includes);
            if (book == null)
            {
                throw new NotFoundException("Book with sent ID does not exist!");
            }
            return book;
        }

        public async Task<bool> RentBook(long BookId, string email)
        {
            Book? book = await _unitOfWork.BookRepository.GetById(BookId, b => b.RentedBooks);
            if (book == null)
            {
                throw new NotFoundException("Book with ID " + BookId + " was not found in database");
            }
            if (GetNumberOfAvailableCopies(book) == 0)
            {
                return false;
            }

            User? user = _unitOfWork.UserRepository.GetAll().FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                throw new NotFoundException("User with email " + email + " was not found in database");
            }

            RentedBook rentedBook = new RentedBook();
            rentedBook.User = user;
            rentedBook.Book = book;
            rentedBook.RentDate = DateTime.UtcNow;

            RentedBook newRentedBook = await _unitOfWork.RentedBookRepository.Create(rentedBook);
            await _unitOfWork.SaveChangesAsync();

            return newRentedBook != null;
        }

        private int GetNumberOfAvailableCopies(Book book)
        {
            int NotReturnedBookNumber = book.RentedBooks.Where(rb => rb.ReturnDate == null).Count();
            return book.Quantity - NotReturnedBookNumber;
        }
    }
}
