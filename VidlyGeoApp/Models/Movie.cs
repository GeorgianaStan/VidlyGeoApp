using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace VidlyGeoApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
          
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        
        [Display(Name = "Date Added")]
        private DateTime? dateAdded;

        public DateTime? DateAdded
        {
            get { return (dateAdded >= (DateTime)SqlDateTime.MinValue) ? dateAdded : (DateTime)SqlDateTime.MinValue; }
            set { dateAdded = value; }
        }


        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; } 

    }
}