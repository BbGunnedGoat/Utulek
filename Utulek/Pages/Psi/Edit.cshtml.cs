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
    public class EditModel : PageModel
    {
        private readonly Utulek.Data.UtulekContext _context;

        public EditModel(Utulek.Data.UtulekContext context)
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

            var pes =  await _context.Pes.FirstOrDefaultAsync(m => m.Id == id);
            if (pes == null)
            {
                return NotFound();
            }
            Pes = pes;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PesExists(Pes.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PesExists(int id)
        {
          return (_context.Pes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
