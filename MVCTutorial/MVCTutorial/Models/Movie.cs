using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTutorial.Models
{
    public enum Genre
    {
        All,
        Comedy,
        Biography,
        Drama,
        Documental
    }
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [EnumDataType(typeof(Genre))]
        public Genre Genre { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
