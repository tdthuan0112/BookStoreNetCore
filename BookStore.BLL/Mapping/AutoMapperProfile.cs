using AutoMapper;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;
using BookStore.DAL.Models;

namespace BookStore.BLL.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<Book, BookDTO>();

            CreateMap<User, UserDTO>();

            CreateMap<Category, CategoryDTO>();

            CreateMap<RequestModelAddToCart, CartItem>();
            CreateMap<RequestModelCart, CartItem>();
        }
    }
}
