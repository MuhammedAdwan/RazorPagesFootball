using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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


         [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Country { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CountrySelected { get; set; }

        public IList<Football> Football { get;set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> CountryQuery = from m in _context.Football
                orderby m.Country
                select m.Country;

             var football = from m in _context.Football
                 select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                football = football.Where(s => s.TeamName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CountrySelected))
            {
                football = football.Where(x => x.Country == CountrySelected);
            }
            Country = new SelectList(await CountryQuery.Distinct().ToListAsync());

            Football = await football.ToListAsync();
        }
    }
}
