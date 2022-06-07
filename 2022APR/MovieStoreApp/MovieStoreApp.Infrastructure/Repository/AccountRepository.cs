using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class AccountRepositoryAsync : IAccountRepositoryAsync
    {
        private readonly UserManager<MovieUser> _userManager;
        public AccountRepositoryAsync(UserManager<MovieUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IdentityResult> SignUpAsync(RegisterModel registerModel)
        {
            MovieUser movieUser = new MovieUser();
            movieUser.FirstName = registerModel.FirstName;
            movieUser.LastName = registerModel.LastName;
            movieUser.Email = registerModel.EmailId;
            movieUser.UserName = registerModel.EmailId.ToString();

            return await _userManager.CreateAsync(movieUser, registerModel.Password);
        }
        
    }
}
