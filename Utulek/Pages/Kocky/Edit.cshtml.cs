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

namespace Utulek.Pages.Kocky
{
    public class EditModel : PageModel
    {
        private readonly Utulek.Data.UtulekContext _context;

        public EditModel(Utulek.Data.UtulekContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Kocka Kocka { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Kocka == null)
            {
                return NotFound();
            }

            var kocka =  await _context.Kocka.FirstOrDefaultAsync(m => m.Id == id);
            if (kocka == null)
            {
                return NotFound();
            }
            Kocka = kocka;
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

            _context.Attach(Kocka).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KockaExists(Kocka.Id))
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

        private bool KockaExists(int id)
        {
          return (_context.Kocka?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
