using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorMegaDesk.Models;

namespace RazorMegaDesk.Data
{
    public class DeskQuotesContext : DbContext
    {
        public DeskQuotesContext (DbContextOptions<DeskQuotesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorMegaDesk.Models.DeskQuote> DeskQuote { get; set; }
    }
}
