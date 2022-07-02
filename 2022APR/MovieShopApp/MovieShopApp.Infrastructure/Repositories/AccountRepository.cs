using Microsoft.AspNetCore.Identity;
using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Entities;
using MovieShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Infrastructure.Repositories
{
    public class AccountRepositoryAsync : IAccountRepositoryAsync
    {
        private readonly UserManager<MovieUser> _userManager;
        public AccountRepositoryAsync(UserManager<MovieUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IdentityResult> SignUpAsync(MovieUserModel model)
        {
            MovieUser movieUser = new MovieUser();
            movieUser.FirstName = model.FirstName;
            movieUser.LastName = model.LastName;
            movieUser.Email = model.EmailId;
            movieUser.UserName = model.EmailId.ToString();      // Use EmailId as userName

            return await _userManager.CreateAsync(movieUser, model.Password);
        }
    }
}
