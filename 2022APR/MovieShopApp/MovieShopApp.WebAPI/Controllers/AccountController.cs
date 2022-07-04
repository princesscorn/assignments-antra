using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Core.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MovieShopApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    //[Authorize]   Can not use Austhorize here, otherwise it will return 404
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServiceAsync _accountServiceAsync;
        private readonly IConfiguration _configuration;
        public AccountController(IAccountServiceAsync accountServiceAsync, IConfiguration configuration)
        {
            _accountServiceAsync = accountServiceAsync;
            _configuration = configuration;
        }

        [HttpPost("SignUp")]    // https://localhost:7250/api/account/signup
        public async Task<IActionResult> SignUp(MovieUserModel movieUserModel)
        {
            var result = await _accountServiceAsync.SignUpAsync(movieUserModel);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized(result.Errors);
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            var result = await _accountServiceAsync.Login(loginModel);
            if (result.Succeeded)
            {
                // use claims to check the token
                var authenticationClaims = new List<Claim> {
                    new Claim(ClaimTypes.Name, loginModel.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

                };
                var secuirtyKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecurityKey"]));
                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddMinutes(20),
                    claims: authenticationClaims,
                    signingCredentials: new SigningCredentials(secuirtyKey, SecurityAlgorithms.HmacSha256Signature)
                    );
                var tokenWrites = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(tokenWrites);
            }
            return Unauthorized();
        }
    }
}
