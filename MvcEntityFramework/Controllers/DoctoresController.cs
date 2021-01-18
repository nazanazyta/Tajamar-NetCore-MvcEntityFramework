using Microsoft.AspNetCore.Mvc;
using MvcEntityFramework.Models;
using MvcEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Controllers
{
    public class DoctoresController : Controller
    {
        RepositoryDoctores repo;

        public DoctoresController(RepositoryDoctores repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UpdateDoctoresEspecialidad()
        {
            List<Doctor> doctores = this.repo.GetDoctores();
            return View(doctores);
        }

        [HttpPost]
        public IActionResult UpdateDoctoresEspecialidad(int iddoctor, String especialidad)
        {
            this.repo.UpdateEspecialidad(iddoctor, especialidad);
            List<Doctor> doctores = this.repo.GetDoctores();
            return View(doctores);
        }

        public IActionResult UpdateDoctoresSalario()
        {
            List<String> especialidades = this.repo.GetEspecialidades();
            ViewData["especialidades"] = especialidades;
            List<Doctor> doctores = this.repo.GetDoctores();
            return View(doctores);
        }

        [HttpPost]
        public IActionResult UpdateDoctoresSalario(int cantidad, String especialidad)
        {
            List<String> especialidades = this.repo.GetEspecialidades();
            ViewData["especialidades"] = especialidades;
            this.repo.UpdateSalario(cantidad, especialidad);
            List<Doctor> doctores = this.repo.GetDoctoresEspecialidad(especialidad);
            return View(doctores);
        }
    }
}
