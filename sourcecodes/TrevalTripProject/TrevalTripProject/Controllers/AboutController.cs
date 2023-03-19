using System.Linq;
using System.Web.Mvc;
using TrevalTripProject.Models.Siniflar;

namespace TrevalTripProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();

            return View(degerler);
        }
    }
}