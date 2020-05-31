using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Data;
using scriptureJournal_cit365.Models;

namespace ScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal.Data.ScripturesContext _context;

        public IndexModel(ScriptureJournal.Data.ScripturesContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortString { get; set; }



        public async Task OnGetAsync()
        {
            //Scripture = await _context.Scripture.ToListAsync();
 
            var scriptures = from s in _context.Scripture
                             select s;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchString) || s.Notes.Contains(SearchString));
            }

//            Scripture = await scriptures.OrderBy(a=> a.CreatedAt).ToListAsync();

            if (!string.IsNullOrEmpty(SortString))
            {
                if (SortString == "CreatedAt")
                {
                    Scripture = await scriptures.OrderBy(a => a.CreatedAt).ToListAsync();
                }
                else if (SortString == "Book")
                {
                    Scripture = await scriptures.OrderBy(a => a.Book).ToListAsync();
                }
            }
            else
            {
                Scripture = await scriptures.OrderBy(a => a.CreatedAt).ToListAsync();
            }


        }
    }
}
