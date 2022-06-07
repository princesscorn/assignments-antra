using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MovieStoreApp.Core.Models;


namespace MovieStoreApp.Core.Contract.Service
{
    public interface IAccountServiceAsync
    {
        Task<IdentityResult> SignUpAsync(RegisterModel registerModel);
    }
}
