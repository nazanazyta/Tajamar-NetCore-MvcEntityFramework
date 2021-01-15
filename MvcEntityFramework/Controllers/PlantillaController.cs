using Microsoft.AspNetCore.Mvc;
using MvcEntityFramework.Models;
using MvcEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Controllers
{
    public class PlantillaController : Controller
    {
        private RepositoryPlantilla repo;

        public PlantillaController(RepositoryPlantilla repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaPlantilla()
        {
            List<Plantilla> plantilla = this.repo.GetPlantilla();
            return View(plantilla);
        }

        public IActionResult PlantillaSalario()
        {
            List<Plantilla> plantilla = this.repo.GetPlantilla();
            ViewData["plantilla"] = plantilla;
            return View();
        }

        [HttpPost]
        public IActionResult PlantillaSalario(int salario)
        {
            ResumenPlantilla resumen = this.repo.FiltrarSalario(salario);
            return View(resumen);
        }
    }
}
