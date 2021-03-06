﻿using FirstApplication.ASPdotNET.MVC5.Books.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.ASPdotNET.MVC5.Books.Controllers
{
    public class CategoriasController : Controller
    {
        private static IList<Categoria> categorias = new List<Categoria>()
        { 
            new Categoria()
            {
                CategoriaId = 1,
                Nome = "Notebooks"
            },
             new Categoria()
            {
                CategoriaId = 2,
                Nome = "Monitores"
            },
             new Categoria()
            {
                CategoriaId = 3,
                Nome = "Impressoras"
            },
             new Categoria()
            {
                CategoriaId = 4,
                Nome = "Mouse"
            },
             new Categoria()
            {
                CategoriaId = 5,
                Nome = "Desktop"
            },
        };

		public IActionResult Index()
        {
            return View(categorias);
        }
    }
}
