using Microsoft.AspNetCore.Mvc;

namespace ToDoApp5.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Hi()
        {
            ViewResult view = new ViewResult();
            //view.ViewName = "BDU";
            List<string> names = ["nunu", "yusif", "xedice","zuzu","cevo"];
            ViewData["Students"]=names;
            //ViewData["name"] = "Fidan";
            //ViewData["surname"] = "veliyeva";
            return View();
        }
    }
}
