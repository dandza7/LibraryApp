using AutoMapper;
using LibraryApp.Models;
using LibraryApp.Models.DTO;

namespace LibraryApp.SupportClasses.AutoMapper
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, PreviewBookDTO>();
            CreateMap<Book, PreviewBookDetailedDTO>().ForMember(b => b.Available, opt => opt.MapFrom(src =>
                src.Quantity - src.RentedBooks.Where(rb => rb.ReturnDate == null).Count()
            ));
            CreateMap<RentedBook, PreviewBookRentEvidentionDTO>()
                .ForMember(rb => rb.Id, opt => opt.MapFrom(src => src.Book.Id))
                .ForMember(rb => rb.Name, opt => opt.MapFrom(src => src.Book.Name))
                .ForMember(rb => rb.IsReturned, opt => opt.MapFrom(src => src.ReturnDate != null));
        }
    }
}
