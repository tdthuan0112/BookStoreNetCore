using BookStore.BLL.Models.DTO;

namespace BookStore.BLL.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllUsers();
        UserDTO GetUserById(Guid userId);
    }
}
