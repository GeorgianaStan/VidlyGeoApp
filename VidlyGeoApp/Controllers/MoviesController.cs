using System.Web.Mvc;
using VidlyGeoApp.Repository;

namespace VidlyGeoApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Index()
        {
            var movies = MoviesRepository.GetMovies();
            return View(movies);
        }
    }
}