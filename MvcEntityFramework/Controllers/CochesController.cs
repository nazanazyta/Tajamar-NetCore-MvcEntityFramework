using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcEntityFramework.Models;

namespace MvcEntityFramework.Controllers
{
    public class CochesController : Controller
    {
        //UN CONTROLADOR DEBERÍA RECIBIR INTERFACES
        private ICoche car;

        //ASÍ, CADA VEZ QUE ENTRA EN EL CONTROLLER, CREA UN OBJETO NUEVO
        //DE ESTA FORMA, AL ACELERAR, SIEMPRE PONE 10, PORQUE SIEMPRE EMPIEZA DE 0
        //public CochesController()
        //{
        //    this.car = new Coche();
        //}

        public CochesController(ICoche car)
        {
            this.car = car;
        }

        public IActionResult Index()
        {
            return View(this.car);
        }

        [HttpPost]
        public IActionResult Index(String accion)
        {
            if (accion.ToLower() == "acelerar")
            {
                this.car.Acelerar();
            }
            else
            {
                this.car.Frenar();
            }
            return View(this.car);
        }
    }
}
