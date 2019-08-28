using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogSite.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="Html"},
                new Category(){KategoriAdi="Css"},
                new Category(){KategoriAdi="Bootstrap"},
                new Category(){KategoriAdi="Javascript"},
            };
            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();
            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){Baslik="Css", Aciklama="Css nedir?", İcerik="İçerik düzenlenecek", EklenmeTarihi=DateTime.Now.AddDays(-5), Anasayfa=true, Onay=true,Resim="3.jpg",CategoryId=2},
              

            };
            foreach (var blog in bloglar)
            {
                context.Bloglar.Add(blog);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}