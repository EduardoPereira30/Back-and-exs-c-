
using CadastroAluno.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAluno.Controllers
{
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        private static List<Fruta> Frutas = new List<Fruta>{
new Fruta{Id = 1, Nome = "Maçã"   , Cor = "Vermelho", Categoria = "Tropical" },
new Fruta{Id = 2, Nome = "Uva"    , Cor = "Roxo"    , Categoria = "Tropical" },
new Fruta{Id = 3, Nome = "Laranja", Cor = "Laranja" , Categoria = "Tropical" },
new Fruta{Id = 4, Nome = "Limão"  , Cor = "Verde"   , Categoria = "Citrica"  },
new Fruta{Id = 5, Nome = "jaca"   , Cor = "amarela" , Categoria = "Citrica"  },
};

        public IActionResult Index()
        {
            return View(Frutas);
        }

        public IActionResult FrutasCitricas()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(Fruta fruta)
        {
            fruta.Id = Frutas.Max(f => f.Id) + 1;
            Frutas.Add(fruta);
            return RedirectToAction("Index");
        }
        public IActionResult FrutasTropícais()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}