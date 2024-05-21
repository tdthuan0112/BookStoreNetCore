using AutoMapper;
using BookStore.BLL.Enum;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.DAL;
using Microsoft.EntityFrameworkCore;

namespace BookStore.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public UserService(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Get All Books From the Database
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<UserDTO> GetAllUsers(BaseResponseErrorModel responseErrorModel)
        {
            List<UserDTO> listUsersDTO = [];
            try
            {
                var listUsers = _context.User
                    .AsNoTracking()
                    .Include(e => e.Role)
                    .ToList();
                listUsersDTO = _mapper.Map<List<UserDTO>>(listUsers);
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorGetAllUsers, ex.Message);
            }
            return listUsersDTO != null && listUsersDTO.Count != 0 ? listUsersDTO : [];
        }

        public UserDTO GetUserById(Guid userId, BaseResponseErrorModel responseErrorModel)
        {
            #region HARDCODE HERE - MODIFY LATER
            var adminUser = _context.User
                .AsNoTracking()
                .FirstOrDefault(e => e.UserName == "Administrator");
            userId = adminUser != null ? adminUser.UserId : new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd");
            #endregion

            UserDTO userDTO = new();
            try
            {
                var user = _context.User
                    .AsNoTracking()
                    .FirstOrDefault(x => x.UserId.Equals(userId));

                if (user != null)
                {
                    userDTO = _mapper.Map<UserDTO>(user);
                }
                else userDTO = new UserDTO();
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorGetUserById, ex.Message);
            }
            return userDTO;
        }
    }
}
