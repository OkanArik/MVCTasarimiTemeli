using Microsoft.AspNetCore.Mvc;

namespace OrnekUygulama.Controllers
{
    //[ApiController]
    //[Route("[Controller]s")]
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            //Burada veri üretirilir burada lazımsa Model e gidiliri veri elde edilir ve bu veri lazımsa View e gönderilir.
            
            ViewResult result = View();//View() fonksiyonu bu actiona ait View(yani .cshtml dosyasını) 'ı tetikleyecek fonksiyondur. 
            //ViewResult result = View();//İlgili boş olan fonksiyon ilgili action ile aynı isimdeki view ı tetikler . Başka bir view ı tetiklemek için View(tetiklenmesini istediğimiz .cshtml dosyasının ismi) şeklinde kullanmalıyız.
            return result;
        }
    }
}
// invoke = çağırmak
// render = işlemek