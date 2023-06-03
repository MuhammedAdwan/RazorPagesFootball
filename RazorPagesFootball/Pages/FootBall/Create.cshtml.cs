using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesFootball.Models;

namespace RazorPagesFootball.Pages_FootBall
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesFootballContext _context;

        public CreateModel(RazorPagesFootballContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Football Football { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Football.Add(Football);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
