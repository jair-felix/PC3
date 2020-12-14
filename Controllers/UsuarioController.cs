using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PC3.Models;
using PC3.Data;

    


namespace PC3.Controllers
{
    public class UsuarioController : Controller
    {

        
        private readonly ILogger<UsuarioController> _logger;
        private readonly DatabaseContext _context;

        public UsuarioController(ILogger<UsuarioController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        
        public IActionResult RegistrarUsuario(usuario objusuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(objusuario);
                _context.SaveChanges();
                
            }
            return View("Confirmacion",objusuario);
            
        }

        public IActionResult Registrar()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}