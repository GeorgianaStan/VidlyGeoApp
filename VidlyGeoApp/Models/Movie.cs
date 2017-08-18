using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyGeoApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
          
        [Required]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public int NumberInStock { get; set; } 

    }
}