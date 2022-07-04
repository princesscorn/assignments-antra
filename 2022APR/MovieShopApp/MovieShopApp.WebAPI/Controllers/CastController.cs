using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Core.Models;

namespace MovieShopApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CastController : ControllerBase
    {
        private readonly ICastServiceAsync _castServiceAsycnc;
        public CastController(ICastServiceAsync castServiceAsync)
        {
            _castServiceAsycnc = castServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _castServiceAsycnc.GetAllCastsAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        //url should like: https://localhost:44390/api/Cast/3
        public async Task<IActionResult> Get(int id)
        {
            // name not referenced, just for example
            return Ok(await _castServiceAsycnc.GetCastByCastIdAsync(id));
        }
        /*
        [HttpGet]
        [Route("{id:int}/{name:length(6)}")]
        //url should like: https://localhost:44390/api/Cast/3/Joseph
        //not this: https://localhost:44390/api/Cast?id=3&name="Joseph", this returns all the casts
        
        public async Task<IActionResult> Get(int id, string name)
        {
            // name not referenced, just for example
            return Ok(await _castServiceAsycnc.GetCastAsync(id));
        }*/

        [HttpPost]
        [Route("add")]
        //this function cannot work until comment the last property of CastModel in Core/Models/CastModels.cs
        public async Task<IActionResult> AddCast([FromBody] CastModel castModel)
        {
            return Ok(await _castServiceAsycnc.AddCastAsync(castModel));
        }

        [HttpDelete]
        [Route("remove/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _castServiceAsycnc.DeleteCastAsync(id));
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] CastModel castModel)
        {
            return Ok(await _castServiceAsycnc.UpdateCastAsync(castModel));
        }
    }
}
