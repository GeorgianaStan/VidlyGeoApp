using System.Linq;
using System.Web.Mvc;
using VidlyGeoApp.Repository;

namespace VidlyGeoApp.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = CustomersRepository.GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = CustomersRepository.GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}