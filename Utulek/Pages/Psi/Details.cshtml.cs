using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Utulek.Data;
using Utulek.Models;

namespace Utulek.Pages.Psi
{
    public class DetailsModel : PageModel
    {
        private readonly Utulek.Data.UtulekContext _context;

        public DetailsModel(Utulek.Data.UtulekContext context)
        {
            _context = context;
        }

      public Pes Pes { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pes == null)
            {
                return NotFound();
            }

            var pes = await _context.Pes.FirstOrDefaultAsync(m => m.Id == id);
            if (pes == null)
            {
                return NotFound();
            }
            else 
            {
                Pes = pes;
            }
            return Page();
        }
    }
}
