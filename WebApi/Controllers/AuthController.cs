using Azure.Core;
using Business.Abstracts;
using Business.Dtos.Auth.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginAuthRequest userForLoginDto)
        {
            var userToLogin = await _authService.Login(userForLoginDto); //logine datalar gönderilip bir değişkene alınıyor
            var result = await _authService.CreateAccessToken(userToLogin);//değişkendeki değerler ile accesstoken oluşturuluyor
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] RegisterAuthRequest userForRegisterDto)
        {
            await _authService.UserExists(userForRegisterDto.Email); //user kontrol

            var registerResult = await _authService.Register(userForRegisterDto, userForRegisterDto.Password);

            var result = await _authService.CreateAccessToken(registerResult);

            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(registerResult);
        }
    }
}
