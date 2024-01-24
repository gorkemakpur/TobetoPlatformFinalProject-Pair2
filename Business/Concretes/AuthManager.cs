using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Auth.Request;
using Business.Dtos.Auth.Response;
using Business.Dtos.Instructor.Request;
using Business.Dtos.User.Request;
using Business.Dtos.User.Response;
using Business.Messagess;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        private IMapper _mapper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper, IMapper mapper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
        }

        public async Task<User> Register(RegisterAuthRequest userForRegisterDto, string password)
        {
            //User user = _mapper.Map<User>(userForRegisterDto);
            User user = new User();
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            user.FirstName = userForRegisterDto.FirstName;
            user.LastName = userForRegisterDto.LastName;
            user.Email = userForRegisterDto.Email;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.Status = true;

            await _userService.Add(user);
            return user;
        }

        public async Task<User> Login(LoginAuthRequest userForLoginDto)
        {
            //useri getiriyoruz mailiyle
            var userToCheck = await _userService.GetByMailAsync(userForLoginDto.Email);
            
            if (userToCheck == null)
            {
                throw new BusinessException(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                throw new BusinessException(Messages.PasswordError);
            }
            var userResponse = _mapper.Map<User>(userToCheck);
            return userResponse;
        }


        public async Task UserExists(string email)
        {
            if (await _userService.GetByMailAsync(email) != null)
            {
                throw new BusinessException(Messages.UserAlreadyExists);
            }
            throw new BusinessException(Messages.Success);
        }

        public async Task<AccessToken> CreateAccessToken(User user)
        {
            var claims = await _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return accessToken;
        }
    }
}
