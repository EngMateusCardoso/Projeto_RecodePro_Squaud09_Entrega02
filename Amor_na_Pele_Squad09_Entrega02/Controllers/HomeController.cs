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

        public IActionResult editarMulher()
        {
            return View();
        }

        public IActionResult editarEmpresa()
        {
            return View();
        }

        //CREATE ou POST ou INSERT

        //Insert na tabela de Newsleter pelas Viwers Index, Parceiros e Links
        [HttpPost]
        public IActionResult cadastroNewsletter(CadastroNewsletter newsletter)
        {
            _context.CadastroNewsletters.Add(newsletter);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //Insert nas tabelas de Contato e Newsletter pela view de contato
        [HttpPost]
        public IActionResult cadastroContatoNewsletter(ModelDuploContatoNewsletter cadcontnews)
        {
            if (!(cadcontnews.cadCont == null))
            {
                _context.CadastroContatos.Add(cadcontnews.cadCont);
                _context.SaveChanges();
            }
            else
            {
                if (!(cadcontnews.cadNews == null))
                {
                    _context.CadastroNewsletters.Add(cadcontnews.cadNews);
                    _context.SaveChanges();
                }
            }
            return View("Index");
        }

        //Insert nas tabelas de Mulher, Empresa e Newsletter pela view de cadastar

        [HttpPost]
        public IActionResult cadastroMulherEmpresaNewsletter(ModelTriploMulherEmpresaNewsletter cadMuEmpNews)
        {
            if (!(cadMuEmpNews.cadMulher == null))
            {
                _context.CadastroMulheres.Add(cadMuEmpNews.cadMulher);
                _context.SaveChanges();
                return RedirectToAction("confirmarMulher");
            }
            else
            {
                if (!(cadMuEmpNews.cadEmp == null))
                {
                    _context.CadastroEmpresas.Add(cadMuEmpNews.cadEmp);
                    _context.SaveChanges();
                    return RedirectToAction("confirmarEmpresa");
                }
                else
                {
                    if (!(cadMuEmpNews.cadNews == null))
                    {
                        _context.CadastroNewsletters.Add(cadMuEmpNews.cadNews);
                        _context.SaveChanges();
                    }
                    return View("Index");
                }
            }

        }

        //READ

        //read do cadastro mulher(neste caso o site apresentará apenas o cadastro da pessoa)
        public IActionResult confirmarMulher()
        {
            List<CadastroMulher> mulher = _context.CadastroMulheres.ToList();
            return View(mulher);
        }


        public IActionResult confirmarEmpresa()
        {
            List<CadastroEmpresa> empresa = _context.CadastroEmpresas.ToList();
            return View(empresa);
        }

    }
}
