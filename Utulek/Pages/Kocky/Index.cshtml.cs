using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Utulek.Data;
using Utulek.Models;

namespace Utulek.Pages.Kocky
{
    public class IndexModel : PageModel
    {
        private readonly Utulek.Data.UtulekContext _context;

        public IndexModel(Utulek.Data.UtulekContext context)
        {
            _context = context;
        }

        public IList<Kocka> Kocka { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Kocka != null)
            {
                Kocka = await _context.Kocka.ToListAsync();
            }
        }
    }
}
