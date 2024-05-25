﻿using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;

namespace BookStore.BLL.Interfaces
{
    public interface IUserService
    {
        List<UserDTO> GetAllUsers(BaseResponseErrorModel responseErrorModel);
        UserDTO GetUserDetailById(Guid userId, BaseResponseErrorModel responseErrorModel);
    }
}
