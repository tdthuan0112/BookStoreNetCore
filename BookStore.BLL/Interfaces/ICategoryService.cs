using BookStore.BLL.Enum;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;

namespace BookStore.BLL.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryDTO> GetAllCategories(BaseResponseErrorModel responseErrorModel);
        CategoryDTO FindCategoryByUrl(string url, BaseResponseErrorModel responseErrorModel);
        List<CategoryDTO> AddCategory(RequestModelCategory requestModel, BaseResponseErrorModel responseErrorModel);
        CategoryDTO FindCategoryById(Guid categoryId, BaseResponseErrorModel responseErrorModel);
        List<CategoryDTO> DeleteCategory(Guid categoryId, BaseResponseErrorModel responseErrorModel);
    }
}
