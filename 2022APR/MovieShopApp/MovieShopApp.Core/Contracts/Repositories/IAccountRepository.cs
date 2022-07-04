using Microsoft.AspNetCore.Identity;
using MovieShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Core.Contracts.Repositories
{
    public interface IAccountRepositoryAsync
    {
        Task<IdentityResult> SignUpAsync(MovieUserModel model);
        Task<SignInResult> Login(LoginModel model);
    }
}
