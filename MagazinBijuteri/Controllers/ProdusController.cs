using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MagazinDeBijuteriiPROIECTFINAL.Models;

namespace MagazinDeBijuteriiPROIECTFINAL.Controllers
{
    public class ProdusController : Controller
    {
        private ProdusContext dbCtx = new ProdusContext();

        // GET: Produs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ProdusModel std = new ProdusModel();
            std.ProdusId = 0;
            std.Denumire = "Denumire";
            std.Descriere = "Descriere";
            std.Cantitate = 0;


            return View(std);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdusModel std)
        {
            if (ModelState.IsValid)
            {
                dbCtx.Produse.Add(std);
                dbCtx.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(std);
        }
    }
}