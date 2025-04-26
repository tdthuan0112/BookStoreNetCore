using AutoMapper;
using BookStore.BLL.Enum;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.DAL;
using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.BLL.Services
{
    public class RoleService : IRoleService
    {

        private readonly BookStoreContext _context;

        private readonly IMapper _mapper;

        private readonly ILoggingConsoleService _loggingConsoleService;

        public RoleService(BookStoreContext context, IMapper mapper, ILoggingConsoleService loggingConsoleService)
        {
            _context = context;
            _mapper = mapper;
            _loggingConsoleService = loggingConsoleService;
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

        public List<RoleDTO> GetAllRoles(BaseResponseErrorModel responseErrorModel)
        {
            List<RoleDTO> listRoleDTO = [];
            try
            {
                var listRoles = _context.Role.AsNoTracking().OrderBy(x => x.RoleName).ToList();
                if(listRoles != null && listRoles.Count != 0)
                {
                    listRoleDTO = _mapper.Map<List<RoleDTO>>(listRoles);
                }
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorInGetRole, ex.Message);
                _loggingConsoleService.LogError(ex);
            }
            return listRoleDTO != null && listRoleDTO.Count != 0 ? listRoleDTO : [];
        }

        public RoleDTO GetRoleDetailById(Guid roleId, BaseResponseErrorModel responseErrorModel)
        {
            RoleDTO roleDTO = new();
            try
            {
                Role role = _context.Role.Where(x => x.RoleId.Equals(roleId)).Single();
                roleDTO = _mapper.Map<RoleDTO>(role);
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.CouldNotFindRoleByRoleId);
                _loggingConsoleService.LogError(ex);
            }
            return roleDTO != null ? roleDTO : new();
        }
    }
}
