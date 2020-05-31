using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace scriptureJournal_cit365.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Notes { get; set; }
        [Display(Name="Created")]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        //Cuando Usamos Scafollded no necesitamos definir constructores. Solo la Clase
       /* public Scripture(string Book, int Chapter, int Verse, string Notes, DateTime CreatedAt)
        {
            this.Book = Book;
            this.Chapter = Chapter;
            this.Verse = Verse;
            this.Notes = Notes;
            this.CreatedAt = CreatedAt;
        }*/
    }
}
