using Microsoft.AspNetCore.Mvc;

namespace GestaoDeEquipamentosWeb.ConsoleApp.Controllers

//MVC - Model, View & Controller


{
    public class HomeController : Controller
    {
        public IActionResult Index() //isso é uma ação chamada index (a página inicial de um controller)
        {
            return View();
        }
    }
}
