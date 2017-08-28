using System.Linq;
using System.Web.Mvc;
using VidlyGeoApp.Models;
using VidlyGeoApp.Models.IdentityModels;
using VidlyGeoApp.ViewModels;

namespace VidlyGeoApp.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");

            return View("ReadOnlyList");
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = _context.Genres.ToList()

            };
            return View("MovieForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel()
            {
                Genres = genres
            };
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var genres = _context.Genres.ToList();
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = genres
                };
                return View("MovieForm", viewModel);
            }
            else
            {
                if (movie.Id == 0)
                {
                    _context.Movies.Add(movie);
                }
                else
                {
                    var movieInBd = _context.Movies.Single(m => m.Id == movie.Id);
                    movieInBd.Name = movie.Name;
                    movieInBd.ReleaseDate = movie.ReleaseDate;
                    movieInBd.GenreId = movie.GenreId;
                    movieInBd.NumberInStock = movie.NumberInStock;
                }

                _context.SaveChanges();

                return RedirectToAction("Index", "Movies");
            }
        }

    }
}