﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }

        [Display(Name="Genre")]
        [Required]
        public int GenreId { get; set; }
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(1,20)]
        [Display(Name="Number in Stock")]
        public int NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}