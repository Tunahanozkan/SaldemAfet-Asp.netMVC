using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaldemAfet.Models.Sınıflar;

namespace SaldemAfet.Controllers
{
    public class YöneticiController : Controller
    {
        // GET: Yönetici
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.afetBilgisis.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniKayıt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKayıt(AfetBilgisi a)
        {
            c.afetBilgisis.Add(a);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KayıtSil(int id)
        {
            var k = c.afetBilgisis.Find(id);
            c.afetBilgisis.Remove(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KayıtGetir(int id)
        {
            var kyt = c.afetBilgisis.Find(id);
            return View("KayıtGetir", kyt);
        }
        public ActionResult KayıtGüncelle(AfetBilgisi a)
        {
            var kyt = c.afetBilgisis.Find(a.afetId);
            kyt.afetTürü = a.afetTürü;
            kyt.afetIl = a.afetIl;
            kyt.afetIlce = a.afetIlce;
            kyt.afetNeden = a.afetNeden;
            kyt.afetbasTarih = a.afetbasTarih;
            kyt.afetbitTarih = a.afetbitTarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}