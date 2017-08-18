using System.Collections.Generic;
using VidlyGeoApp.Models;

namespace VidlyGeoApp.ViewModels
{
    public class MovieFormViewModel
    {
       public IEnumerable<Genre> Genres { get; set; }

        public Movie Movie { get; set; }
    }
}