using AutoMapper;
using BookStore.BLL.Enum;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.DAL;

namespace BookStore.BLL.Services
{
    public class RoleService : IRoleService
    {

        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public RoleService(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public RoleDTO GetRoleByRoleName(string roleName, BaseResponseErrorModel baseResponseErrorModel)
        {
            RoleDTO roleDTO = new();
            try
            {
                var role = _context.Role.Where(x => x.RoleName == roleName).FirstOrDefault();
                if (role == null)
                {
                    baseResponseErrorModel.SetErrorModel(ResponseError.CouldNotFindRoleByRoleName);
                }
                roleDTO = _mapper.Map<RoleDTO>(role);
            }
            catch (Exception ex)
            {
                baseResponseErrorModel.SetErrorModel(ResponseError.ErrorInGetRole, ex.Message);
            }
            return roleDTO;
        }
    }
}
