using System.Runtime.CompilerServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//doi ten namespace
namespace NetCoreDemo.Models
{
    public class Movie
    { 
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is require")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}