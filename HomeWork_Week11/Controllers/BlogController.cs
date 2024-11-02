using HomeWork_Week11.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_Week11.Controllers
{
    public class BlogController : Controller
    {
        List<BlogModel> bloglist;
        
        public BlogController()
        {
            bloglist = [
                new BlogModel { Id=1, Aciklama="bu birinci açıklama", Baslik="1.BAŞLIK",Resim="https://picsum.photos/id/237/200/300"

                },
                new BlogModel { Id=2, Aciklama="bu İKİNCİ açıklama", Baslik="2.BAŞLIK",Resim="https://picsum.photos/id/237/200/300"

                },new BlogModel { Id=3, Aciklama="bu ÜÇÜNCÜ açıklama", Baslik="3.BAŞLIK",Resim="https://picsum.photos/id/237/200/300"

                },new BlogModel { Id=4, Aciklama="bu DÖRDÜNCÜ açıklama", Baslik="4.BAŞLIK", Resim="https://picsum.photos/id/237/200/300"

                },new BlogModel { Id=5, Aciklama="bu BEŞİNCİ açıklama", Baslik="5.BAŞLIK", Resim="https://picsum.photos/id/237/200/300"

                },new BlogModel { Id=6, Aciklama="bu ALTINCI açıklama", Baslik="6.BAŞLIK",Resim="https://picsum.photos/id/237/200/300"

                },new BlogModel { Id=7, Aciklama="bu YEDİNCİ açıklama", Baslik="7.BAŞLIK",Resim="https://picsum.photos/id/237/200/300"

                },new BlogModel { Id=8, Aciklama="bu SEKİZİNCİ açıklama", Baslik="8.BAŞLIK",Resim="https://picsum.photos/id/237/200/300"

                },new BlogModel { Id=9, Aciklama="bu DOKUZUNCU açıklama", Baslik="9.BAŞLIK",Resim="https://picsum.photos/id/237/200/300"

                },new BlogModel { Id=10, Aciklama="bu ONUNCU açıklama", Baslik="10.BAŞLIK",Resim="https://picsum.photos/id/237/200/300"

                },

            ];
        }
        
        public ActionResult Index()
        {
            ViewBag.BlogList=bloglist;
            return View();
        }

    }
}
