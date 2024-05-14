using AutoMapper;
using BookStore.BLL.Models.DTO;
using BookStore.DAL.Models;

namespace BookStore.BLL.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<Book, BookDTO>();
            CreateMap<BookDTO, Book>();
        }
    }
}
