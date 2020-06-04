using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Wesselink_Evenementen.Model;

namespace Wesselink_Evenementen.Pages.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public async Task OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("/Account/Index.cshtml");
            }
            else
            {
                Console.WriteLine("Something went wrong with authentication???");
            }
        }
    }
}