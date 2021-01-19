using Microsoft.AspNetCore.Mvc;
using MvcEntityFramework.Models;
using MvcEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Controllers
{
    public class TodosEmpleadosController : Controller
    {
        RepositoryTodosEmpleados repo;

        public TodosEmpleadosController(RepositoryTodosEmpleados repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<String> nombres = this.repo.GetNombres();
            return View(nombres);
        }

        [HttpPost]
        public IActionResult Index(String nombre)
        {
            List<String> nombres = this.repo.GetNombres();
            ProcedimientoTodosEmpleados datos = this.repo.GetTodosEmpleados(nombre);
            ViewData["datos"] = datos;
            return View(nombres);
        }
    }
}
