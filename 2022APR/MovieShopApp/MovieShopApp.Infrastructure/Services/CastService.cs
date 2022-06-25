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
    public class CastServiceAsync : ICastServiceAsync
    {
        private readonly ICastRepositoryAsync _castRepositoryAsync;
        public CastServiceAsync(ICastRepositoryAsync castRepositoryAsync)
        {
            _castRepositoryAsync = castRepositoryAsync;
        }

        public async Task<IEnumerable<CastModel>> GetAllCastsAsync()
        {
            // repository just get this method implemented by it's base class.
            var result = await _castRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                List<CastModel> list = new List<CastModel>();
                foreach (var item in result)
                {
                    CastModel model = new CastModel();
                    model.Id = item.Id;
                    model.Name = item.Name;
                    model.TmdbUrl = item.TmdbUrl;
                    model.ProfilePath = item.ProfilePath;
                    model.Gender = item.Gender;
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        public async Task<CastModel> GetCastByCastIdAsync(int id)
        {
            // repository just get this method implemented by it's base class.
            var item = await _castRepositoryAsync.GetByIdAsync(id);
            if (item != null)
            {
                CastModel model = new CastModel();
                model.Id = item.Id;
                model.Name = item.Name;
                model.TmdbUrl = item.TmdbUrl;
                model.ProfilePath = item.ProfilePath;
                model.Gender = item.Gender;
                return model;
            }
            return null;
        }

        public async Task<int> AddCastAsync(CastModel model)
        {
            Cast c = new Cast();
            c.Name = model.Name;
            c.TmdbUrl = model.TmdbUrl;
            c.ProfilePath = model.ProfilePath;
            c.Gender = model.Gender;
            return await _castRepositoryAsync.InsertAsync(c);
        }

        public async Task<int> DeleteCastAsync(int id)
        {
            return await _castRepositoryAsync.DeleteAsync(id);
        }

        public async Task<int> UpdateCastAsync(CastModel model)
        {
            Cast c = new Cast();
            c.Name = model.Name;
            c.TmdbUrl = model.TmdbUrl;
            c.ProfilePath = model.ProfilePath;
            c.Gender = model.Gender;
            return await _castRepositoryAsync.UpdateAsync(c);
        }
    }
}
