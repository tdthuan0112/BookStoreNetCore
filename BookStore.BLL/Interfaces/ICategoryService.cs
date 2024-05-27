using BookStore.BLL.Enum;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;

namespace BookStore.BLL.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryDTO> GetAllCategories(BaseResponseErrorModel responseErrorModel);
        List<CategoryDTO> GetAllActiveCategories(BaseResponseErrorModel responseErrorModel);
        CategoryDTO GetCategoryDetailByUrl(string url, BaseResponseErrorModel responseErrorModel);
        List<CategoryDTO> AddNewCategory(RequestModelAddCategory requestModel, BaseResponseErrorModel responseErrorModel);
        List<CategoryDTO> UpdateCategory(RequestModelUpdateCategory requestModel, BaseResponseErrorModel responseErrorModel);
        CategoryDTO GetCategoryDetailById(Guid categoryId, BaseResponseErrorModel responseErrorModel);
        List<CategoryDTO> DeleteCategory(Guid categoryId, BaseResponseErrorModel responseErrorModel);
    }
}
