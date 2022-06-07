using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Infrastructure.Service
{
    public class AccountServiceAsync : IAccountServiceAsync
    {
        private readonly IAccountRepositoryAsync _accountRepositoryAsync ;
        public AccountServiceAsync(IAccountRepositoryAsync accountRepositoryAsync)
        {
            _accountRepositoryAsync = accountRepositoryAsync;
        }

        public async Task<IdentityResult> SignUpAsync(RegisterModel registerModel)
        {
            return await _accountRepositoryAsync.SignUpAsync(registerModel);
        }
    }
}
