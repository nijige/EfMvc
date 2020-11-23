using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nutri.Mvc.Models;

namespace Nutri.Controllers
{
  public class DietaController : Controller
  {
    private readonly ILogger<DietaController> _logger;
    public DietaController(ILogger<DietaController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }
  }
}