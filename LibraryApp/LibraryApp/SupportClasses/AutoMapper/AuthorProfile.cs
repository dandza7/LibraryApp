using AutoMapper;
using LibraryApp.Models;
using LibraryApp.Models.DTO;

namespace LibraryApp.SupportClasses.AutoMapper
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, PreviewAuthorDTO>();
            CreateMap<PreviewAuthorDTO, Author>();
            CreateMap<NewAuthorDTO, Author>();
        }
    }
}
