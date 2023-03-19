
using System.Linq;
using System.Web.Mvc;
using TrevalTripProject.Models.Siniflar;
namespace TrevalTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(4).ToList();
            return View(degerler);
        }

        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.OrderBy(x => x.ID).Take(1).ToList();

            return PartialView(degerler);
        }

        public PartialViewResult Partial3()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial4()
        {
            var degerler = c.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial5()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(degerler);
        }
    }
}