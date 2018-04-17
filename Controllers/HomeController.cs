using Microsoft.AspNetCore.Mvc;
// using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        [Route("/test")] //localhost:5000/test in browser
        public string Test() { return "Testing 1, 2, 3"; }

    }
}
