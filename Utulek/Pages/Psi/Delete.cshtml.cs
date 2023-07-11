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
    public class DeleteModel : PageModel
    {
        private readonly Utulek.Data.UtulekContext _context;

        public DeleteModel(Utulek.Data.UtulekContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Pes == null)
            {
                return NotFound();
            }
            var pes = await _context.Pes.FindAsync(id);

            if (pes != null)
            {
                Pes = pes;
                _context.Pes.Remove(Pes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
