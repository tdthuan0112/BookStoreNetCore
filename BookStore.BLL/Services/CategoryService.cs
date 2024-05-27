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
            List<CategoryDTO> listCategoryDTO = [];
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

        public List<CategoryDTO> GetAllActiveCategories(BaseResponseErrorModel responseErrorModel)
        {
            List<CategoryDTO> listCategoryDTO = [];
            try
            {
                var listCategories = _context.Category.AsNoTracking().Where(x => x.IsActive).OrderBy(x => x.Name).ToList();
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

        public CategoryDTO GetCategoryDetailByUrl(string url, BaseResponseErrorModel responseErrorModel)
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

        public List<CategoryDTO> AddNewCategory(RequestModelAddCategory requestModel, BaseResponseErrorModel responseErrorModel)
        {
            //VALIDATE REQUEST
            try
            {
                var cate = _context.Category.Where(x => x.Url.Equals(requestModel.Url)).FirstOrDefault();
                if (cate != null)
                {
                    responseErrorModel.SetErrorModel(ResponseError.ErrorInAddCategoryExistedUrl, "");
                }
                else
                {
                    Category category = new()
                    {
                        CategoryId = Guid.NewGuid(),
                        Name = requestModel.Name,
                        Url = requestModel.Url,
                        Quantity = requestModel.Quantity,
                        CreatedBy = requestModel.CreatedBy,
                        DateCreated = DateTime.Now,
                        IsActive = requestModel.IsActive
                    };
                    _context.Category.Add(category);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorInAddCategory, ex.Message);
            }
            return GetAllCategories(responseErrorModel);
        }

        public List<CategoryDTO> UpdateCategory(RequestModelUpdateCategory requestModel, BaseResponseErrorModel responseErrorModel)
        {
            //VALIDATE REQUEST
            try
            {
                var cate = _context.Category.Where(x => x.Url.Equals(requestModel.Url) &&! x.CategoryId.Equals(requestModel.CategoryId)).FirstOrDefault();
                if (cate != null)
                {
                    responseErrorModel.SetErrorModel(ResponseError.ErrorInAddCategoryExistedUrl, "");
                }
                else
                {
                    _context.Category.Where(x => x.CategoryId.Equals(requestModel.CategoryId))
                        .ExecuteUpdate(cate => cate
                            .SetProperty(b => b.Name, requestModel.Name)
                            .SetProperty(b => b.Url, requestModel.Url)
                            .SetProperty(b => b.Quantity, requestModel.Quantity)
                            .SetProperty(b => b.IsActive, requestModel.IsActive)
                            .SetProperty(b => b.ModifiedBy, requestModel.ModifiedBy)
                            .SetProperty(b => b.DateLastModified, DateTime.Now)
                        );
                }
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorInAddCategory, ex.Message);
            }
            return GetAllCategories(responseErrorModel);
        }

        public CategoryDTO GetCategoryDetailById(Guid categoryId, BaseResponseErrorModel responseErrorModel)
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
