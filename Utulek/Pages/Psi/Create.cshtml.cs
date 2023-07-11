using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Utulek.Data;
using Utulek.Models;

namespace Utulek.Pages.Psi
{
    public class CreateModel : PageModel
    {
        private readonly Utulek.Data.UtulekContext _context;

        public CreateModel(Utulek.Data.UtulekContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pes Pes { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Pes == null || Pes == null)
            {
                return Page();
            }

            _context.Pes.Add(Pes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
