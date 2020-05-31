using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using scriptureJournal_cit365.Models;

namespace ScriptureJournal.Data
{
    public class ScripturesContext : DbContext
    {
        public ScripturesContext (DbContextOptions<ScripturesContext> options)
            : base(options)
        {
        }

        public DbSet<scriptureJournal_cit365.Models.Scripture> Scripture { get; set; }
    }
}
