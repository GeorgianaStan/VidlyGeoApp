using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VidlyGeoApp.Models;

namespace VidlyGeoApp.ViewModels
{
    public class MovieFormViewModel
    {
       public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        public int? NumberInStock { get; set; }

        private string title;

        public string Title => Id == 0 ? "New Movie" : "Edit Movie";

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}