using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var bloglar = context.Bloglar.Where(i => i.Anasayfa == true && i.Onay == true)
                .Select(a=> new BlogModel()
                {
                   Id=a.Id,
                   Baslik=a.Baslik.Length >100?a.Baslik.Substring(0,100)+"...":a.Baslik,
                   Aciklama=a.Aciklama,
                   Resim=a.Resim,
                   Anasayfa =a.Anasayfa,
                   Onay=a.Onay,
                   EklenmeTarihi=a.EklenmeTarihi

                });
            return View(bloglar.ToList());
        }
    }
}