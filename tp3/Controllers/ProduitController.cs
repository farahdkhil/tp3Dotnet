using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tp3.Models;

namespace tp3.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult Index()
        {
            ViewBag.Message = "Hello to the home page of TP3";
            return View();

        }
        public ActionResult DisplayOneProduct()
        {
            Produit produit = new Produit
            {
                Id = 1,
                Name = "Produit 1",
                Prix = 109
            };
            ViewBag.Produit = produit;
            // n3adi l'objet lil vue
            return View();
        }
        public ActionResult DisplayManyproducts()
        {
            List<Produit> produits = new List<Produit>
        {
            new Produit { Id = 1, Name = "Produit 1", Prix = 10456.909 },
            new Produit { Id = 2, Name = "Produit 2", Prix = 2020.499 },
            new Produit { Id = 3, Name = "Produit 3", Prix = 15789.75 }
        };

            // ViewData bch trj3 liste des produits lil vue
            ViewData["ListeProduits"] = produits;

            // nrj donnee fil vue
            return View("DisplayManyproducts");
        }
    }
}