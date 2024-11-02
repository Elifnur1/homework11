using HomeWork_Week11.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_Week11.Controllers
{
    public class AboutController : Controller
    {
        List<AboutModel>aboutlist;
        public AboutController()
        {
            aboutlist = [
                new AboutModel{ Özgecmis="Adım Elif ve Acun Medya Akademiden şuanda yazılım eğitimi alıyorum.Buda benim MVC projem.MVC yeni öğreniyorum çok karmaşık gibi duruyordu ama aslında anlaşılması kolay bir dosyalama yapısıymış,şuanda öğrenmesi daha eğlenceli..Hatta MVC projesi tasarlamak daha da eğlenceli :)"

                }
            ];
        }
        public ActionResult Index()
        {
           ViewBag.AboutList=aboutlist;
            return View();
        }

    }
}
