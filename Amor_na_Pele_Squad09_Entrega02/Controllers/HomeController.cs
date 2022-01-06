using Amor_na_Pele_Squad09_Entrega02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Amor_na_Pele_Squad09_Entrega02.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;

        public HomeController(Context contexto)
        {
            _context = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult cadastrar()
        {
            return View();
        }

        public IActionResult parceiros()
        {
            return View();
        }

        public IActionResult contato()
        {
            return View();
        }

        public IActionResult links()
        {
            return View();
        }

        public IActionResult cadastrarEmpresa()
        {
            return View();
        }

        public IActionResult cadastrarPessoa()
        {
            return View();
        }

        //CREATE

        //contato
        [HttpPost]
        public IActionResult contato(CadastroContato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return View("Index");
        }

        //Cadastro da mulher
        [HttpPost]
        public IActionResult cadastroMulher(CadastroMulher cadastroMulher)
        {
            _context.Add(cadastroMulher);
            _context.SaveChanges();
            return View("cadastrar");
        }

        //Cadastro Empresa
        [HttpPost]
        public IActionResult cadastroEmpresa(CadastroEmpresa cadastroEmpresa)
        {
            _context.Add(cadastroEmpresa);
            _context.SaveChanges();
            return View("cadastrar");
        }

        //Cadastro Newsletter
        [HttpPost]
        public IActionResult cadastroNewsletter(CadastroNewsletter cadastroNewsletter)
        {
            _context.Add(cadastroNewsletter);
            _context.SaveChanges();
            return View("Index");
        }
    }
}
