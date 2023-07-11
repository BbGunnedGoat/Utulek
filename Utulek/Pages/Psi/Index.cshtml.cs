using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Utulek.Data;
using Utulek.Models;

namespace Utulek.Pages.Psi
{
    public class IndexModel : PageModel
    {
        private readonly Utulek.Data.UtulekContext _context;

        public IndexModel(Utulek.Data.UtulekContext context)
        {
            _context = context;
        }

        public IList<Pes> Pes { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Plemena { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? PsiPlemena { get; set; }

        public async Task OnGetAsync()
        {
            var psi = from m in _context.Pes select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                psi = psi.Where(s => s.Jmeno.Contains(SearchString));
            }
            Pes = await psi.ToListAsync();
        }
    }
}
