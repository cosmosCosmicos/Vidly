using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        //public Movie Movie { get; set; }

        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? RealeseDate { get; set; }

        [Required(ErrorMessage = "Number in stock must be between 1 and 20")]
        [Display(Name = "Number in stock")]
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }
        public IEnumerable<Genre> Genres{ get; set; }
        public string Title {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            RealeseDate = movie.RealeseDate;
            NumberInStock = movie.NumberInStock;
            
        }
    }
}