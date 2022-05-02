using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WkWebApplication.Models;

namespace WkWebApplication.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Categorias = new Categoria().ObterTodos();
            return View();
        }
    }
}
