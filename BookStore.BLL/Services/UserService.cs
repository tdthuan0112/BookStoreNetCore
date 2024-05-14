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
                var listUsers = await _context.User.AsNoTracking().Include(e => e.Role).ToListAsync();
                listUsersDTO = _mapper.Map<List<UserDTO>>(listUsers);
            }
            catch (Exception ex)
            {
                throw new Exception(message: $"Error in get all books - ${ex.Message}");
            }
            return listUsersDTO != null && listUsersDTO.Count != 0 ? listUsersDTO : [];
        }
    }
}
