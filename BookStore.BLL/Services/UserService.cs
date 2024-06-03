using AutoMapper;
using BookStore.BLL.Constant;
using BookStore.BLL.Enum;
using BookStore.BLL.Extensions;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;
using BookStore.DAL;
using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace BookStore.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;
        private readonly IRoleService _roleService;
        private readonly ConfigAuthentication _configAuth;

        public UserService(BookStoreContext context, IMapper mapper, IRoleService roleService, IOptions<ConfigAuthentication> configAuthOptions)
        {
            _context = context;
            _mapper = mapper;
            _roleService = roleService;
            _configAuth = configAuthOptions.Value;
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

        public UserDTO GetUserDetailById(Guid userId, BaseResponseErrorModel responseErrorModel)
        {
            //#region HARDCODE HERE - MODIFY LATER
            //var adminUser = _context.User
            //    .AsNoTracking()
            //    .FirstOrDefault(e => e.UserName == "Administrator");
            //userId = adminUser != null ? adminUser.UserId : new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd");
            //#endregion

            UserDTO userDTO = new();
            try
            {
                var user = _context.User
                    .AsNoTracking()
                    .Include(x => x.Role)
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

        public UserDTO GetUserDetailByUserName(string userName, BaseResponseErrorModel responseErrorModel)
        {
            UserDTO userDTO = null;
            try
            {
                var user = _context.User
                .AsNoTracking()
                .Include(x => x.Role)
                .FirstOrDefault(x => x.UserName.Equals(userName));

                if (user != null)
                {
                    userDTO = _mapper.Map<UserDTO>(user);
                }
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorGetUserById, ex.Message);
            }
            return userDTO;
        }

        public string CreateUser(RequestModelAddUser requestModel, BaseResponseErrorModel baseResponseErrorModel)
        {
            try
            {
                var buyerRole = _roleService.GetRoleByRoleName("Buyer", baseResponseErrorModel);
                if(buyerRole != null && !baseResponseErrorModel.HasError())
                {
                    User newUser = new()
                    {
                        UserName = requestModel.UserName,
                        UserPassword = CryptoExt.Encrypt(requestModel.Password, _configAuth.SecretKey),
                        FirstName = requestModel.FirstName,
                        LastName = requestModel.LastName,
                        Email = requestModel.Email,
                        Gender = requestModel.Gender,
                        PhoneNumber = requestModel.PhoneNumber,
                        Address = requestModel.Address,
                        DistrictId = requestModel.DistrictId,
                        DistrictName = requestModel.DistrictName,
                        WardId = requestModel.WardId,
                        WardName = requestModel.WardName,
                        ProvinceId = requestModel.ProvinceId,
                        ProvinceName = requestModel.ProvinceName,
                        DateOfBirth = requestModel.DateOfBirth,
                        DateCreated = DateTime.Now,
                        IsActive = true,
                        RoleId = buyerRole.RoleId,
                    };
                    _context.User.Add(newUser);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                baseResponseErrorModel.SetErrorModel(ResponseError.ErrorInAddNewUser, ex.Message);
            }
            return "Success create user";
        }

        public List<UserDTO> DeleteUserByUserId(Guid userId, BaseResponseErrorModel responseErrorModel)
        {
            //#region HARDCODE HERE - MODIFY LATER
            //var adminUser = _context.User
            //    .AsNoTracking()
            //    .FirstOrDefault(e => e.UserName == "Administrator");
            //userId = adminUser != null ? adminUser.UserId : new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd");
            //#endregion

            try
            {
                _context.User
                    .Where(x => x.UserId.Equals(userId))
                    .ExecuteDelete();
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorInDeleteUserByUserId, ex.Message);
            }
            List<UserDTO> listUsers = GetAllUsers(responseErrorModel);
            return listUsers;
        }
    }
}
