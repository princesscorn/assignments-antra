using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Core.Entities
{
    public class MovieUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Other propertities(UserName, PasswordHash, SecurityStamp, PhoneNumber, TwoFactorEnabled...) are inherited from IdentityUser
    }
}
