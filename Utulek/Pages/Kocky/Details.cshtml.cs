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
    public class DetailsModel : PageModel
    {
        private readonly Utulek.Data.UtulekContext _context;

        public DetailsModel(Utulek.Data.UtulekContext context)
        {
            _context = context;
        }

      public Kocka Kocka { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Kocka == null)
            {
                return NotFound();
            }

            var kocka = await _context.Kocka.FirstOrDefaultAsync(m => m.Id == id);
            if (kocka == null)
            {
                return NotFound();
            }
            else 
            {
                Kocka = kocka;
            }
            return Page();
        }
    }
}
