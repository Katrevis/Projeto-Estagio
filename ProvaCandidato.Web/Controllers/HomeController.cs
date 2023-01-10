using ProvaCandidato.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProvaCandidato.Controllers
{
  public class HomeController : Controller
  {
        
        private readonly CidadeRepositorio _cidadeRepositorio;

        public HomeController()
        {
            _cidadeRepositorio = new CidadeRepositorio();
        }
    public ActionResult Index()
    {
       var cidades = _cidadeRepositorio.ListarCidades();
            
      return View(cidades);
    }
  }
}