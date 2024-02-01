using Business.Dtos.Auth.Request;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IAuthService
    {
        Task<User> Register(RegisterAuthRequest userForRegisterDto, string password);
        Task<User> Login(LoginAuthRequest loginAuthRequest);
        Task<User> ForgetPassword(ForgetPasswordAuthRequest forgetPasswordAuthRequest);
        Task<string> ResetPassword(ResetPasswordAuthRequest resetPasswordAuthRequest);
        Task<string> UpdatePassword(UpdatePasswordAuthRequest updatePasswordAuthRequest, string password);
        Task UserExists(string email);
        Task<AccessToken> CreateAccessToken(User user);
    }
}
