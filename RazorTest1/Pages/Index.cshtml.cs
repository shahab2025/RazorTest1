using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTest1.Data;
using RazorTest1.Model;

namespace RazorTest1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorTest1.Data.RazorTest1Context _context;

        public IndexModel(RazorTest1.Data.RazorTest1Context context)
        {
            _context = context;
        }

        public IList<Users> Users { get;set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
