using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyGeoApp.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }


        public DateTime ReleaseDate { get; set; }


        //[Display(Name = "Date Added")]
        //private DateTime? dateAdded;
        //public DateTime? DateAdded
        //{
        //    get { return (dateAdded >= (DateTime)SqlDateTime.MinValue) ? dateAdded : (DateTime)SqlDateTime.MinValue; }
        //    set { dateAdded = value; }
        //}


        public int NumberInStock { get; set; }
    }
}