using Microsoft.AspNetCore.Mvc;
using MvcCoreClienteApiHospital.Models;
using MvcCoreClienteApiHospital.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreClienteApiHospital.Controllers
{
    public class HospitalesController : Controller
    {
        private ServiceApiHospital service;

        public HospitalesController (ServiceApiHospital service)
        {
            this.service = service;
        }
        public IActionResult HospitalesCliente()
        {
            return View();
        }

        public async Task<IActionResult> HospitalesServidor()
        {
            List<Hospital> hospitales =
                await this.service.GetHospitalesAsync();
            return View(hospitales);
        }
    }
}
