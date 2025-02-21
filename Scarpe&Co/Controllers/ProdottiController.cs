using Microsoft.AspNetCore.Mvc;
using Scarpe_Co.Models;
using Scarpe_Co.Repository;

namespace Scarpe_Co.Controllers
{
    public class ProdottiController : Controller
    {
        public IActionResult Index()
        {
            return View(ProdottoRepository.Prodotti);
        }

        public IActionResult Dettagli(Guid id)
        {
            var prodotto = ProdottoRepository.Prodotti.FirstOrDefault(p => p.Id == id);
            if (prodotto == null) return NotFound();
            return View(prodotto);
        }

        public IActionResult Aggiungi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Aggiungi(Prodotto prodotto)
        {
            if (ModelState.IsValid)
            {
                ProdottoRepository.AggiungiProdotto(prodotto);
                return RedirectToAction("Index");
            }
            return View(prodotto);
        }


        public IActionResult Modifica(Guid id)
        {
            var prodotto = ProdottoRepository.Prodotti.FirstOrDefault(p => p.Id == id);
            if (prodotto == null) return NotFound();
            return View(prodotto);
        }

        [HttpPost]
        public IActionResult Modifica(Prodotto prodotto)
        {
            if (ModelState.IsValid)
            {
                ProdottoRepository.ModificaProdotto(prodotto);
                return RedirectToAction("Dettagli", new { id = prodotto.Id });
            }
            return View(prodotto);
        }
    }
}
