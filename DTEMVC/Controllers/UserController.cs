using DTEMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DTEMVC.Controllers
{
    public class UserController : Controller
    {
       public IActionResult Index()
        {
            // Datos de ejemplo para la tabla
            var users = new List<User>
            {
                new User { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Role = "Admin" },
                new User { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Role = "User" },
                new User { Id = 3, FirstName = "Sam", LastName = "Wilson", Email = "sam.wilson@example.com", Role = "User" },
                 new User { Id = 4, FirstName = "Rolando", LastName = "Jose", Email = "rjgarcia@example.com", Role = "User" },
            };

            return View(users);
        }
    }
}
