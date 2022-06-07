using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;

namespace MovieStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServiceAsync _accountServiceAsync;
        public AccountController(IAccountServiceAsync accountServiceAsync)
        {
            _accountServiceAsync = accountServiceAsync;
        }
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(RegisterModel registerAccount)
        {
            var result = await _accountServiceAsync.SignUpAsync(registerAccount);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized(result.Errors);
        }
    }
}
