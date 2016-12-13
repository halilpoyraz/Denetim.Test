using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.IO;
using System.Web.Optimization;
using System.Data.Entity;


namespace DENETİM.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        DENETİMEntities1 context = new DENETİMEntities1();
        public ActionResult Index()
        {
            return View();
        }

        //
        //
        //Kategori Liste Bilgileri

        public ActionResult ListeBilgileriKategori()
        {
            return View(context.KATEGORI.ToList());
        }

        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(KATEGORI kat)
        {
            context.KATEGORI.Add(kat);
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriKategori");
        }

        public ActionResult KategoriDuzenle(int id)
        {
            return View(context.KATEGORI.FirstOrDefault(x => x.ID == id));
        }

        [HttpPost]
        public ActionResult KategoriDuzenle(KATEGORI kat)
        {
            context.Entry(kat).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriKategori");
        }

        public ActionResult KategoriSil(int id)
        {
            context.KATEGORI.Remove(context.KATEGORI.FirstOrDefault(x => x.ID == id));
            
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriKategori");
        }

        //
        //
        //Tür Liste Bilgileri

        public ActionResult ListeBilgileriTur()
        {
            return View(context.TUR.ToList());
        }

        public ActionResult TurEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TurEkle(TUR tur)
        {
            context.TUR.Add(tur);
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriTur");
        }

        public ActionResult TurDuzenle(int id)
        {
            return View(context.TUR.FirstOrDefault(x => x.ID == id));
            
        }

        [HttpPost]
        public ActionResult TurDuzenle(TUR tur)
        {
            context.Entry(tur).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriTur");
        }

        public ActionResult TurSil(int id)
        {
            context.TUR.Remove(context.TUR.FirstOrDefault(x => x.ID == id));
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriTur");
        }


        //
        //
        //Bölüm Liste Bilgileri

        public ActionResult ListeBilgileriBolum()
        {
            return View(context.BOLUM.ToList());
        }

        public ActionResult BolumEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BolumEkle(BOLUM bol)
        {
            context.BOLUM.Add(bol);
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriBolum");
        }

        public ActionResult BolumDuzenle(int id)
        {
            return View(context.BOLUM.FirstOrDefault(x => x.ID == id));
        }

        [HttpPost]
        public ActionResult BolumDuzenle(BOLUM bol)
        {
            context.Entry(bol).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriBolum");
        }

        public ActionResult BolumSil(int id)
        {
            context.BOLUM.Remove(context.BOLUM.FirstOrDefault(x => x.ID == id));
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriBolum");
        }


        //
        //
        //Başlık Liste Bilgileri

        public ActionResult ListeBilgileriBaslik()
        {
            return View(context.BASLIK.ToList());
        }

        public ActionResult BaslikEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BaslikEkle(BASLIK bas)
        {
            context.BASLIK.Add(bas);
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriBaslik");
        }

        public ActionResult BaslikDuzenle(int id)
        {
            return View(context.BASLIK.FirstOrDefault(x => x.ID == id));
        }

        [HttpPost]
        public ActionResult BaslikDuzenle(BASLIK bas)
        {
            context.Entry(bas).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriBaslik");
        }

        public ActionResult BaslikSil(int id)
        {
            context.BASLIK.Remove(context.BASLIK.FirstOrDefault(x => x.ID == id));
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriBaslik");
        }

        //
        //
        //Alt Başlık Liste Bilgileri

        public ActionResult ListeBilgileriBaslikAlt()
        {
            
            return View(context.BASLIKALT.ToList());
        }

        public ActionResult BaslikAltEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BaslikAltEkle(BASLIKALT abas)
        {
            context.BASLIKALT.Add(abas);
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriBaslikAlt");
        }

        public ActionResult BaslikAltDuzenle(int id)
        {
            return View(context.BASLIKALT.FirstOrDefault(x => x.ID == id));
        }

        [HttpPost]
        public ActionResult BaslikAltDuzenle(BASLIKALT abas)
        {
            context.Entry(abas).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriBaslikAlt");
        }

        public ActionResult BaslikAltSil(int id)
        {
            context.BASLIKALT.Remove(context.BASLIKALT.FirstOrDefault(x => x.ID == id));
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriBaslikAlt");
        }



        //
        //
        //DDOKUMANLAR

        public ActionResult ListeBilgileriDokumanlar()
        {
            return View(context.DDOKUMANLAR.ToList());
        }

        public ActionResult DokumanEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DokumanEkle(DDOKUMANLAR dok)
        {
            context.DDOKUMANLAR.Add(dok);
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriDokumanlar");
        }

        public ActionResult DokumanDuzenle(int id)
        {
            return View(context.DDOKUMANLAR.FirstOrDefault(x => x.ID == id));
        }

        [HttpPost]
        public ActionResult DokumanDuzenle(DDOKUMANLAR dok)
        {
            context.Entry(dok).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriDokumanlar");
        }

        public ActionResult DokumanSil(int id)
        {
            context.DDOKUMANLAR.Remove(context.DDOKUMANLAR.FirstOrDefault(x => x.ID == id));
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriDokumanlar");
        }


        //
        //
        //DSTANDARTLAR

        public ActionResult ListeBilgileriStandartlar()
        {
            return View(context.DSTANDARTLAR.ToList());
        }

        public ActionResult StandartEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StandartEkle(DSTANDARTLAR stan)
        {
            context.DSTANDARTLAR.Add(stan);
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriStandartlar");
        }

        public ActionResult StandartDuzenle(int id)
        {
            return View(context.DSTANDARTLAR.FirstOrDefault(x => x.ID == id));
        }

        [HttpPost]
        public ActionResult StandartDuzenle(DSTANDARTLAR stan)
        {
            context.Entry(stan).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriStandartlar");
        }

        public ActionResult StandartSil(int id)
        {
            context.DSTANDARTLAR.Remove(context.DSTANDARTLAR.FirstOrDefault(x => x.ID == id));
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriStandartlar");
        }


        //
        //
        //KISALTMALAR

        public ActionResult ListeBilgileriKısaltmalar()
        {
            return View(context.KISALTMALAR.ToList());
        }

        public ActionResult KısaltmaEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KısaltmaEkle(KISALTMALAR kıs)
        {
            context.KISALTMALAR.Add(kıs);
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriKısaltmalar");
        }

        public ActionResult KısaltmaDuzenle(int id)
        {
            return View(context.KISALTMALAR.FirstOrDefault(x => x.ID == id));
        }

        [HttpPost]
        public ActionResult KısaltmaDuzenle(KISALTMALAR kıs)
        {
            context.Entry(kıs).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriKısaltmalar");
        }

        public ActionResult KısaltmaSil(int id)
        {
            context.KISALTMALAR.Remove(context.KISALTMALAR.FirstOrDefault(x => x.ID == id));
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriKısaltmalar");
        }

        //
        //
        //TERIMLER

        public ActionResult ListeBilgileriTerimler()
        {
            return View(context.TERIMLER.ToList());
        }

        public ActionResult TerimEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TerimEkle(TERIMLER ter)
        {
            context.TERIMLER.Add(ter);
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriTerimler");
        }

        public ActionResult TerimDuzenle(int id)
        {
            return View(context.TERIMLER.FirstOrDefault(x => x.ID == id));
        }

        [HttpPost]
        public ActionResult TerimDuzenle(TERIMLER ter)
        {
            context.Entry(ter).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriTerimler");
        }

        public ActionResult TerimSil(int id)
        {
            context.TERIMLER.Remove(context.TERIMLER.FirstOrDefault(x => x.ID == id));
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriTerimler");
        }


        //
        //
        //Maddeler

        public ActionResult ListeBilgileriMaddeler()
        {
            return View(context.MADDELER.ToList());
        }

        public ActionResult MaddeEkle()
        {
            ViewBag.BaslikAlt = context.BASLIKALT.ToList();
            ViewBag.Baslik = context.BASLIK.ToList();
            ViewBag.Bolum = context.BOLUM.ToList();
            ViewBag.Ketegori = context.KATEGORI.ToList();
            ViewBag.Tur = context.TUR.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult MaddeEkle(MADDELER mad)
        {
            context.MADDELER.Add(mad);
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriMaddeler");
        }

        public ActionResult MaddeDuzenle(int mad)
        {
            return View(context.MADDELER.FirstOrDefault(x => x.ID == mad));
        }

        [HttpPost]
        public ActionResult MaddeDuzenle(MADDELER mad)
        {
            context.Entry(mad).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriMaddeler");
        }

        public ActionResult MaddeSil(int id)
        {
            context.MADDELER.Remove(context.MADDELER.FirstOrDefault(x => x.ID == id));
            context.SaveChanges();
            return RedirectToAction("ListeBilgileriMaddeler");
        }
    }
}
