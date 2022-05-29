using Microsoft.AspNetCore.Mvc;

namespace FisrtProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var myView = new ViewResult();
            myView.ViewName = "Index";
            return myView;
        }
    }
}
