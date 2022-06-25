using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Core.Entities;
using MovieShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Infrastructure.Services
{
    public class GenreServiceAsync : IGenreServiceAsync
    {
        private readonly IGenreRepositoryAsync _genreRepositoryAsync;
        public GenreServiceAsync(IGenreRepositoryAsync genreRepositoryAsync)
        {
            _genreRepositoryAsync = genreRepositoryAsync;
        }

        public async Task<int> AddGenreAsync(GenreModel model)
        {
            Genre g = new Genre();
            g.Id = model.Id;
            g.Name = model.Name;
            return await _genreRepositoryAsync.InsertAsync(g);
        }

        public async Task<IEnumerable<GenreModel>> GetAllGenresAsync()
        {
            // repository just get this method implemented by it's base class.
            var result = await _genreRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                List<GenreModel> list = new List<GenreModel>();
                foreach (var item in result)
                {
                    GenreModel model = new GenreModel();
                    model.Id = item.Id;
                    model.Name = item.Name;
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        public async Task<GenreModel> GetGenreByGenreIdAsync(int id)
        {
            // repository just get this method implemented by it's base class.
            var item = await _genreRepositoryAsync.GetByIdAsync(id);
            if (item != null)
            {
                GenreModel model = new GenreModel();
                model.Id = item.Id;
                model.Name = item.Name;
                return model;
            }
            return null;
        }

        public async Task<int> DeleteGenreByIdAsync(int id)
        {
            return await _genreRepositoryAsync.DeleteAsync(id);
        }

        public async Task<int> UpdateGenreAsync(GenreModel model)
        {
            Genre g = new Genre();
            g.Name = model.Name;
            return await _genreRepositoryAsync.UpdateAsync(g);
        }

    }
}
