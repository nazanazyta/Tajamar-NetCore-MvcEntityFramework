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
            return View();
        }

        public IActionResult IncrementarSalarios()
        {
            List<Empleado> empleados = this.repo.GetEmpleados();
            List<String> oficios = this.repo.GetOficios();
            ViewData["oficios"] = oficios;
            return View(empleados);
        }

        [HttpPost]
        public IActionResult IncrementarSalarios(String oficio, int incremento)
        {
            List<Empleado> empleados = this.repo.GetEmpleadosOficio(oficio);
            this.repo.IncrementarSalariosOficio(oficio, incremento);
            List<String> oficios = this.repo.GetOficios();
            ViewData["oficios"] = oficios;
            return View(empleados);
        }

        public IActionResult EmpleadosDepartamentoLambda()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmpleadosDepartamentoLambda(int dept)
        {
            ResumenDepartamento model = this.repo.GetResumenDepartamento(dept);
            return View(model);
        }
    }
}
