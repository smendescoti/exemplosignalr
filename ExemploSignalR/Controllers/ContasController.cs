﻿using Microsoft.AspNetCore.Mvc;

namespace ExemploSignalR.Controllers
{
    public class ContasController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Consulta()
        {
            return View();
        }
    }
}
