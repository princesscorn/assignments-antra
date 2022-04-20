using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /*First Example*/
        [HttpGet]
        [Route("Welcome")]
        public string GetWelcomeMessage()
        {
            return "Welcome to Web API.";
        }

        [HttpGet]
        [Route("CountryName")]
        [Route("GetCountryName")]
        public string GetCountryName()
        {
            return "China";
        }

        [HttpGet]
        [Route("{Name}")]
        public string GetInputName(string name)
        {
            return "Hi, name";
        }
    }
}
