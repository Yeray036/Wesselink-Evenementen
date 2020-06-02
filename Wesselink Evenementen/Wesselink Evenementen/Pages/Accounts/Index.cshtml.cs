using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IEnumerable<Verified_Users> Verified_Users { get; set; }

        public async Task OnGet()
        {
            Verified_Users = await _db.Verified_Users.ToListAsync();
        }
    }
}