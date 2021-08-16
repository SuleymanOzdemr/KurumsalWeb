
using KurumsalWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KurumsalWeb.Controllers
{
    
    public class AdminController : Controller
    {
        KurumsalDb db = new KurumsalDb();
        
        // GET: Admin
        public ActionResult Index()
        {
            var sorgu = db.Kategoris.ToList();
            return View(sorgu);
        }
    }
}