using System.Linq;
using System.Web.Mvc;
using TrevalTripProject.Models.Siniflar;
namespace TrevalTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogYorum blogYorum = new BlogYorum();
        // GET: Blog
        public ActionResult Index()
        {
            //var degerler = c.Blogs.ToList();
            blogYorum.Deger1 = c.Blogs.ToList();
            blogYorum.Deger3 = c.Blogs.OrderByDescending(o => o.ID).Take(3).ToList();
            return View(blogYorum);
        }


        public ActionResult BlogDetay(int id)
        {


            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();

            blogYorum.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            blogYorum.Deger3 = c.Blogs.OrderByDescending(o => o.ID).Take(3).ToList();

            return View(blogYorum);
        }

        [HttpGet]
        public PartialViewResult YorumYap()
        {

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y, int id)
        {
            y.Blogid = id;
            c.Yorumlars.Add(y);

            c.SaveChanges();
            return PartialView();
        }
    }
}