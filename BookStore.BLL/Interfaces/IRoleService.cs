using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;

namespace BookStore.BLL.Interfaces
{
    public interface IRoleService
    {
        RoleDTO GetRoleByRoleName(string roleName, BaseResponseErrorModel baseResponseErrorModel);
    }
}
