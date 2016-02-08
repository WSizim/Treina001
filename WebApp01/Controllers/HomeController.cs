using System.Web.Mvc;
using WebApp01.Models;

namespace WebApp01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registro()
        {
            var registro = new RegistroModel();
            return View(registro);
        }

        [HttpPost]
        public ActionResult Registro(RegistroModel registro)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Obrigado", registro);
            }
            else
            {
                return View(registro);
            }
        }

        public ActionResult Obrigado(RegistroModel registro)
        {
            return View(registro);
        }

        public ActionResult Sobre()
        {
            return View();
        }

    }
}