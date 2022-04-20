using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;

namespace MovieStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreServiceAsync _genreServiceAsycnc;
        public GenreController(IGenreServiceAsync genreServiceAsycnc)
        {
            _genreServiceAsycnc = genreServiceAsycnc;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _genreServiceAsycnc.GetAllGenresAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        //url should like: https://localhost:44390/api/Genre/3
        public async Task<IActionResult> Get(int id)
        {
            // name not referenced, just for example
            return Ok(await _genreServiceAsycnc.GetGenreByIdAsync(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddGenre([FromBody] GenreModel genreModel)
        {
            return Ok(await _genreServiceAsycnc.AddGenreAsync(genreModel));
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _genreServiceAsycnc.DeleteGenreByIdAsync(id));
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] GenreModel genreModel)
        {
            return Ok(await _genreServiceAsycnc.UpdateGenreByIdAsync(genreModel));
        }
    }
}
