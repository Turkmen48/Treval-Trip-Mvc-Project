using System.Web.Mvc;
using TrevalTripProject.Models.Siniflar;

namespace TrevalTripProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Iletisim ileti)
        {
            c.Iletisims.Add(ileti);
            c.SaveChanges();
            return View();
        }
    }
}