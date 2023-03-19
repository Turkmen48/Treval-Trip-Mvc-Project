using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using TrevalTripProject.Models.Siniflar;

namespace TrevalTripProject.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap

        Context c = new Context();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin adm)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == adm.Kullanici && x.Sifre == adm.Sifre);
            if (bilgiler != null)
            {

                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.LoginError = "Hatalı Kullanıcı Adı veya Şifre";
                return View();
            }

        }
    }
}