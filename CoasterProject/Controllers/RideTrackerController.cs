using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoasterProject.Controllers
{
    public class RideTrackerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}