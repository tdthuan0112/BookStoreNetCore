using BookStore.BLL.Constant;
using BookStore.BLL.Interfaces;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.VisualBasic;
using BookStore.BLL.Models.Response;
using BookStore.BLL.Models;
using BookStore.BLL.Enum;
using Newtonsoft.Json.Linq;

namespace BookStore.BLL.Services
{
    public class JwtService : IJwtService
    {
        private readonly ConfigJwt _configJwt;


        public JwtService(IOptions<ConfigJwt> configJwtOptions)
        {
            _configJwt = configJwtOptions.Value;
        }
        public JwtCreateModel GenerateJWTSecurityToken(Guid userId, string userName = "", string email = "", string roleName = "")
        {
            var secureKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configJwt.SecretKey));
            var credentials = new SigningCredentials(secureKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName,userId.ToString()),
                new Claim(JwtRegisteredClaimNames.Name,userName),
                new Claim(JwtRegisteredClaimNames.Email,email),
                new Claim(JwtRegisteredClaimNames.Sub,roleName),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };
            var timeExpired = DateTime.Now.AddMinutes(_configJwt.ExpiresInMinutes);
            var jwToken = new JwtSecurityToken(
                issuer: _configJwt.Issuer,
                audience: _configJwt.Audience,
                claims,
                expires: timeExpired,
                signingCredentials: credentials
                );

            return new JwtCreateModel
            {
                Token = new JwtSecurityTokenHandler().WriteToken(jwToken),
                Expiration = timeExpired
            };
        }

        public JwtResponseUserModel ValidateJWTSercurityToken(string token, BaseResponseErrorModel responseErrorModel)
        {
            if (token == null || String.IsNullOrEmpty(token))
            {
                responseErrorModel.SetErrorModel(ResponseError.TokenIsEmpty);
                return null;
            }
            else
            {
                JwtSecurityTokenHandler jwtTokenHandle = new();
                var validationParameters = new TokenValidationParameters
                {
                    ValidateLifetime = true,
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configJwt.SecretKey)),
                    ValidAudience = _configJwt.Audience,
                    ValidIssuer = _configJwt.Issuer,
                    ClockSkew = TimeSpan.Zero
                };
                var jwtToken = jwtTokenHandle.ReadToken(token) as JwtSecurityToken;
                ClaimsPrincipal validateResult;
                JwtResponseUserModel jwtResponse = new();
                try
                {
                    validateResult = jwtTokenHandle.ValidateToken(token, validationParameters, out var validatedToken);
                    if (jwtToken != null && jwtToken.Claims != null && jwtToken.Claims.Any())
                    {
                        var userName = jwtToken.Claims.FirstOrDefault(claim => claim.Type == JwtRegisteredClaimNames.Name)?.Value;
                        if (userName != null)
                            jwtResponse.UserName = userName;
                        var userId = jwtToken.Claims.FirstOrDefault(claim => claim.Type == JwtRegisteredClaimNames.UniqueName)?.Value;
                        if (userId != null)
                            jwtResponse.UserId = new Guid(userId);
                        var email = jwtToken.Claims.FirstOrDefault(claim => claim.Type == JwtRegisteredClaimNames.Email)?.Value;
                        if (email != null)
                            jwtResponse.Email = email;
                        var roleName = jwtToken.Claims.FirstOrDefault(claim => claim.Type == JwtRegisteredClaimNames.Sub)?.Value;
                        if (roleName != null)
                            jwtResponse.RoleName = roleName;
                    }
                }
                catch (SecurityTokenExpiredException ex)
                {
                    responseErrorModel.SetErrorModel(ResponseError.ExpiredToken, ex.Message);
                }
                catch (Exception ex)
                {
                    responseErrorModel.SetErrorModel(ResponseError.ErrorInValidateToken, ex.Message);
                }
                return jwtResponse;
            }
        }
    }
}
