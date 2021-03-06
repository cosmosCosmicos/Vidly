﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        public GenreDto Genre { get; set; }
        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime RealeseDate { get; set; }

        [Required(ErrorMessage = "Number in stock must be between 1 and 20")]
        [Display(Name = "Number in stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}