using KurumsalWeb.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace KurumsalWeb.Controllers
{
    public class HomeController : Controller
    {
        private KurumsalDBContext db = new KurumsalDBContext();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Hizmetler = db.Hizmet.ToList().OrderByDescending(x=>x.HizmetId);
            //ViewBag.Iletisim = db.Iletisim.SingleOrDefault();
            ViewBag.Blog = db.Blog.ToList().OrderByDescending(x => x.BlogId);
            return View();
        }
        public ActionResult SliderPartial()
        {
            return View(db.Slider.ToList().OrderByDescending(x => x.SliderId));

        }
        public ActionResult HizmetPartial()
        {
            return View(db.Hizmet.ToList());
        }

        public ActionResult Hakkimizda()
        {
            return View(db.Hakkimizda.ToList().OrderByDescending(x => x.HakkimizdaId));
        }
        public ActionResult Hizmetlerimiz()
        {
            return View(db.Hizmet.ToList().OrderByDescending(x => x.HizmetId));
        }
        public ActionResult Iletisim()
        {
            return View(db.Iletisim.ToList().OrderByDescending(x=>x.IletisimId));
        }

        [HttpPost]
        public ActionResult Iletisim(string adsoyad=null,string email=null,string konu=null,string mesaj=null)
        {
            if (adsoyad!=null && email!=null && konu!=null && mesaj!=null)
            {
                WebMail.SmtpServer = "smtp.gmail.com";
                WebMail.EnableSsl = true;
                WebMail.UserName = "suleymanoz385@gmail.com";
                WebMail.Password = "Mermer.123";
                WebMail.SmtpPort = 587;
                WebMail.Send("suleymanoz385@gmail.com", konu, email + "-" + mesaj);
                ViewBag.Uyari = "Mesajınız başarıyla gonderildi";
            }
            else
            {
                ViewBag.Uyari = "Hata oluştu tekrar deneyiniz";
            }
            return View();
        }
    }
}