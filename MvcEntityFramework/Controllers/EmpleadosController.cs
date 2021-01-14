using Microsoft.AspNetCore.Mvc;
using MvcEntityFramework.Models;
using MvcEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Controllers
{
    public class EmpleadosController : Controller
    {
        private RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Empleado> empleados = this.repo.GetEmpleados();
            List<String> oficios = this.repo.GetOficios();
            ViewData["oficios"] = oficios;
            return View(empleados);
        }

        [HttpPost]
        public IActionResult Index(String oficio, int incremento)
        {
            this.repo.IncrementarSalario(oficio, incremento);
            List<Empleado> empleados = this.repo.GetEmpleadosOficio(oficio);
            List<String> oficios = this.repo.GetOficios();
            ViewData["oficios"] = oficios;
            return View(empleados);
        }
    }
}
