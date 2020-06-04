using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Wesselink_Evenementen.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the VerifiedDbLogin class
    public class VerifiedDbLogin : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
