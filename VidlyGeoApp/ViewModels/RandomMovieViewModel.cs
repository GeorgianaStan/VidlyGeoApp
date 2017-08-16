using System.Collections.Generic;
using VidlyGeoApp.Models;

namespace VidlyGeoApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers  { get; set; }        
    }
}