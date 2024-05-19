using AutoMapper;
using BookStore.BLL.Interfaces;
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
        public async Task<List<UserDTO>> GetAllUsers()
        {
            List<UserDTO> listUsersDTO;
            try
            {
                var listUsers = await _context.User
                    .AsNoTracking()
                    .Include(e => e.Role)
                    .ToListAsync();
                listUsersDTO = _mapper.Map<List<UserDTO>>(listUsers);
            }
            catch (Exception ex)
            {
                throw new Exception(message: $"Error in get all books - ${ex.Message}");
            }
            return listUsersDTO != null && listUsersDTO.Count != 0 ? listUsersDTO : [];
        }

        public UserDTO GetUserById(Guid userId)
        {
            #region HARDCODE HERE - MODIFY LATER
            var adminUser = _context.User
                .AsNoTracking()
                .FirstOrDefault(e => e.UserName == "Administrator");
            userId = adminUser != null ? adminUser.UserId : new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd");
            #endregion

            UserDTO userDTO;
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
                throw new Exception(message: $"Error in get user by id: ${userId} - ${ex.Message}");
            }
            return userDTO;
        }
    }
}
