using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesFootball.Models;

namespace RazorPagesFootball.Pages_FootBall
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesFootballContext _context;

        public DetailsModel(RazorPagesFootballContext context)
        {
            _context = context;
        }

        public Football Football { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Football = await _context.Football.FirstOrDefaultAsync(m => m.ID == id);

            if (Football == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
