using System.Web.Mvc;
using VidlyGeoApp.Repository;

namespace VidlyGeoApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Index()
        {
            var moviesRep = new MoviesRepository();
            var movies = moviesRep.GetMovies();
            return View(movies);
        }
    }
}