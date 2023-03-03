using AutoMapper;
using LibraryApp.Models;
using LibraryApp.Models.DTO;

namespace LibraryApp.SupportClasses.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, NewUserDTO>();
            CreateMap<NewUserDTO, User>();
            CreateMap<User, PreviewUserDTO>();
            CreateMap<PreviewUserDTO, User>();
            CreateMap<RentedBook, PreviewUserRentEvidentionDTO>()
                .ForMember(rb => rb.Id, opt => opt.MapFrom(src => src.User.Id))
                .ForMember(rb => rb.FirstName, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(rb => rb.LastName, opt => opt.MapFrom(src => src.User.LastName))
                .ForMember(rb => rb.Email, opt => opt.MapFrom(src => src.User.Email))
                .ForMember(rb => rb.IsReturned, opt => opt.MapFrom(src => src.ReturnDate != null));
        }
    }
}
