using AutoMapper;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models.DTO;
using BookStore.DAL;
using Microsoft.EntityFrameworkCore;

namespace BookStore.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public CategoryService(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<CategoryDTO>> GetAllCategories()
        {
            List<CategoryDTO> listCategoryDTO;
            try
            {
                var listCategories = await _context.Category.AsNoTracking().ToListAsync();
                listCategoryDTO = _mapper.Map<List<CategoryDTO>>(listCategories);
            }
            catch (Exception ex)
            {
                throw new Exception(message: $"Error in get all categories - ${ex.Message}");
            }
            return listCategoryDTO != null && listCategoryDTO.Count != 0 ? listCategoryDTO : [];
        }
    }
}
