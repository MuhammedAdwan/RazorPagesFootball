using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesFootball.Models;

    public class RazorPagesFootballContext : DbContext
    {
        public RazorPagesFootballContext (DbContextOptions<RazorPagesFootballContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesFootball.Models.Football> Football { get; set; }
    }
