using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;

namespace BookStore.BLL.Interfaces
{
    public interface IUserService
    {
        List<UserDTO> GetAllUsers(BaseResponseErrorModel responseErrorModel);
        UserDTO GetUserDetailById(Guid userId, BaseResponseErrorModel responseErrorModel);
        UserDTO GetUserDetailByUserName(string userName, BaseResponseErrorModel responseErrorModel);
        string CreateUser(RequestModelAddUser requestModel, BaseResponseErrorModel baseResponseErrorModel);
        List<UserDTO> DeleteUserByUserId(Guid userId, BaseResponseErrorModel baseResponseErrorModel);
    }
}
