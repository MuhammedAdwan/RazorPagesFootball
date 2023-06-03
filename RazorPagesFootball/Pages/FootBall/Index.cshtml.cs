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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesFootballContext _context;

        public IndexModel(RazorPagesFootballContext context)
        {
            _context = context;
        }

        public IList<Football> Football { get;set; }

        public async Task OnGetAsync()
        {
            Football = await _context.Football.ToListAsync();
        }
    }
}
