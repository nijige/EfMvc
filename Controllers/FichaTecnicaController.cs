using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nutri.Models;

namespace Nutri.Controllers
{
    public class FichaTecnicaController : Controller
    {
        public IActionResult FichaTecnica()
        {
            return View();
        }


    }
}