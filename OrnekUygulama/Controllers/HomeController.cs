using Microsoft.AspNetCore.Mvc;

namespace OrnekUygulama.Controllers
{
    //[ApiController] // Controller'ın request e bir response döneceğini taahhüt eder.
    //[Route("[Controller]s")] // https//.....Homes/
    public class HomeController : Controller //HomeController 'ı Controller calss'ı yapan şey Microsoft.AspNetCore.Mvc namespace'i altından gelen Controller sınıfından kalıtım almasıdır. 
    {
        //Controller sınıfları içerisinde istekleri karşılayan methodlara action method denir.
        //Controller sınıfları içerisinde tanımlanan tüm methodlar action method olarak nitelendirilirler.
        //Action method: Controller a gelen isteği karşılayan ve gerekli işlemleri gerçekleştiren methotdur.

        public IActionResult index()
        {
            return View();
        }
    }
}
