using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TRIFAN_RAUL_EXAMEN_FINAL.Data;
using TRIFAN_RAUL_EXAMEN_FINAL.Models;

namespace TRIFAN_RAUL_EXAMEN_FINAL.Pages.Meniu
{
    public class CreateModel : PageModel
    {
        private readonly TRIFAN_RAUL_EXAMEN_FINAL.Data.TRIFAN_RAUL_EXAMEN_FINALContext _context;

        public CreateModel(TRIFAN_RAUL_EXAMEN_FINAL.Data.TRIFAN_RAUL_EXAMEN_FINALContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Restaurant.Add(Restaurant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
