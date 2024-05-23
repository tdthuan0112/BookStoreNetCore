using AutoMapper;
using BookStore.BLL.Enum;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;
using BookStore.DAL;
using BookStore.DAL.Models;
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

        public List<CategoryDTO> GetAllCategories(BaseResponseErrorModel responseErrorModel)
        {
            List<CategoryDTO> listCategoryDTO = new();
            try
            {
                var listCategories = _context.Category.AsNoTracking().OrderBy(x => x.Name).ToList();
                if (listCategories != null && listCategories.Count != 0)
                {
                    int indexOfAllBook = listCategories.FindIndex(x => x.Url.Equals("all-books"));
                    var allBookCate = listCategories[indexOfAllBook];
                    listCategories.RemoveAt(indexOfAllBook);
                    listCategories.Insert(indexOfAllBook, allBookCate);
                    listCategoryDTO = _mapper.Map<List<CategoryDTO>>(listCategories);
                }
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorGetAllCategory, ex.Message);
            }
            return listCategoryDTO != null && listCategoryDTO.Count != 0 ? listCategoryDTO : [];
        }

        public CategoryDTO FindCategoryByUrl(string url, BaseResponseErrorModel responseErrorModel)
        {
            CategoryDTO categoryDTO = new();
            try
            {
                Category category = _context.Category.Where(x => x.Url.Equals(url)).Single();
                categoryDTO = _mapper.Map<CategoryDTO>(category);
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorInFindCategoryByUrl, ex.Message);
            }

            return categoryDTO ?? new CategoryDTO();
        }

        public List<CategoryDTO> AddCategory(RequestModelCategory requestModel, BaseResponseErrorModel responseErrorModel)
        {
            //VALIDATE REQUEST
            Category category = new Category
            {
                CategoryId = Guid.NewGuid(),
                Name = requestModel.Name,
                Url = requestModel.Url,
                CreatedBy = requestModel.CreatedBy,
                DateCreated = DateTime.Now,
                IsActive = true
            };
            if (category != null)
            {
                try
                {
                    _context.Category.Add(category);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    responseErrorModel.SetErrorModel(ResponseError.ErrorInAddCategory, ex.Message);
                }
            }
            return GetAllCategories(responseErrorModel);
        }

        public CategoryDTO FindCategoryById(Guid categoryId, BaseResponseErrorModel responseErrorModel)
        {
            CategoryDTO categoryDTO = new();
            try
            {
                Category category = _context.Category.Where(x => x.CategoryId.Equals(categoryId)).Single();
                categoryDTO = _mapper.Map<CategoryDTO>(category);
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorInFindCategoryById, ex.Message);
            }

            return categoryDTO ?? new CategoryDTO();
        }

        public List<CategoryDTO> DeleteCategory(Guid categoryId, BaseResponseErrorModel responseErrorModel)
        {
            List<CategoryDTO> listCategoryDTO = [];
            try
            {
                _context.Category.Where(x => x.CategoryId.Equals(categoryId)).ExecuteDelete();
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorInDeleteCategoryById, ex.Message);
            }

            listCategoryDTO = GetAllCategories(responseErrorModel);

            return listCategoryDTO ?? [];
        }
    }
}
