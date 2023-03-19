using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using TrevalTripProject.Models.Siniflar;

namespace TrevalTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        [Authorize]

        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        [Authorize]

        public ActionResult YeniBlog(Blog p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]

        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]

        public ActionResult BlogGetir(int id)
        {
            var b = c.Blogs.Find(id);

            return View(b);
        }

        [Authorize]

        public ActionResult BlogGuncelle(Blog b)
        {
            var blog = c.Blogs.Find(b.ID);
            blog.Aciklama = b.Aciklama;
            blog.Baslik = b.Baslik;
            blog.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        [Authorize]

        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }

        [Authorize]

        public ActionResult YorumSil(int id)
        {
            c.Yorumlars.Remove(c.Yorumlars.Find(id));
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        [Authorize]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }

        [Authorize]
        public ActionResult Iletisim()
        {
            var degerler = c.Iletisims.ToList();
            return View(degerler);
        }

        [Authorize]
        public ActionResult IletisimSil(int id)
        {
            c.Iletisims.Remove(c.Iletisims.Find(id));
            c.SaveChanges();

            return RedirectToAction("Iletisim", "Admin");
        }


        [Authorize]
        public ActionResult Hakkimizda()
        {
            var hakkimizda = c.Hakkimizdas.Find(1);
            return View(hakkimizda);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Hakkimizda(Hakkimizda p1)
        {
            var hakkimizda = c.Hakkimizdas.Find(1);
            hakkimizda.Aciklama = p1.Aciklama;
            hakkimizda.FotoUrl = p1.FotoUrl;
            c.SaveChanges();
            return View();
        }
    }
}