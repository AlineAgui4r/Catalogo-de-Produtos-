using Microsoft.AspNetCore.Mvc;

namespace CatalogoDeProdutos.Controllers;

public class ProdutoController : Controller
{
    public IActionResult Index()
    {
        
        var produtos = new List<string>
        {
            "Notebook",
            "Mouse",
            "Teclado",
            "Monitor",
            "Headset"
        };

       
        var precos = new List<double>
        {
            3500.00,
            79.90,
            149.90,
            1200.00,
            89.90
        };

        ViewBag.Produtos = produtos;
        ViewBag.Precos = precos;

        return View();
    }
}