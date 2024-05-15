using BookStore.BLL.Models.DTO;

namespace BookStore.BLL.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDTO>> GetAllCategories();
    }
}
