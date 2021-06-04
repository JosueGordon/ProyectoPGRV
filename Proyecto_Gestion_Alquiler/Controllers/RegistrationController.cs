using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Gestion_Alquiler.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult user_Registration()
        {
            return View();
        }
    }
}
