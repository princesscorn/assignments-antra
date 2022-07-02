using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Core.Models;


namespace MovieShopApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    //[Authorize]   Can not use Austhorize here, otherwise it will return 404
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServiceAsync _accountServiceAsync;
        public AccountController(IAccountServiceAsync accountServiceAsync)
        {
            _accountServiceAsync = accountServiceAsync;
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
    }
}
