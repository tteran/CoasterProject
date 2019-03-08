using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoasterProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace CoasterProject.Controllers
{
    public class RollerCoasterController : Controller
    {
        private IRollerCoasterDAO rollerCoasterDAO;
        public RollerCoasterController(IRollerCoasterDAO rollerCoasterDAO)
        {
            this.rollerCoasterDAO = rollerCoasterDAO;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}