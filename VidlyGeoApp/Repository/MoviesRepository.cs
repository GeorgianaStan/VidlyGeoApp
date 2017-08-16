using System.Collections.Generic;
using VidlyGeoApp.Models;

namespace VidlyGeoApp.Repository
{
    public static class MoviesRepository
    {
        public static IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() { Id = 1, Name = "Shrek" },
                new Movie() { Id = 1, Name = "Wall-e" }
            };
        }
    }
}