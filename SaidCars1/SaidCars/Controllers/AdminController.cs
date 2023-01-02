using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HayvanBarinagiCalisma.Data;
using HayvanBarinagiCalisma.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity;
using System.Net.Http.Headers;
using System.IO;

namespace HayvanBarinagiCalisma.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public AdminController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
           return View(_context.Iletisim.ToList());
        }
        public IActionResult ArabaEkle()
        {
            var viewModel = new ArabaTurMarkaViewModel();
            viewModel.Turler = _context.Tur.ToList();
            viewModel.Markalar = _context.Marka.ToList();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult ArabaEkle(Araba araba)
        {
            var viewModel = new ArabaTurMarkaViewModel();
            viewModel.Turler = _context.Tur.ToList();
            viewModel.Markalar = _context.Marka.ToList();
            if (Request.Form.Files.Count > 0 && ModelState.IsValid)
            {
                string dosyaAdi = Path.GetFileName(Request.Form.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Form.Files[0].FileName);
                string dbAd = araba.Adi + araba.MarkaId.ToString() + araba.TurId.ToString()+ araba.Model.ToString() + araba.EkBilgiler + uzanti;
                string yol = "wwwroot/img/" + dbAd; //+ uzanti;
                using (FileStream fs = System.IO.File.Create(yol))
                {
                    Request.Form.Files[0].CopyTo(fs);
                    fs.Flush();
                }
                araba.Foto = "/img/" + dbAd;
                //hayvan.Marka = _context.Marka.Find(hayvan.MarkaId);
               // hayvan.Tur = _context.Tur.Find(hayvan.TurId);
                _context.Araba.Add(araba);
                _context.SaveChanges();
                viewModel.Araba = araba;
                ViewBag.Mesaj = "Ekleme Başarılı";
                return View(viewModel);
            }
            ViewBag.Error = "Ekleme başarısız!";
            return View(viewModel);
        }
        public IActionResult ArabaDuzenle()
        {
            var viewModel = new ArabalarTurMarkaViewModel();
            viewModel.Araba = _context.Araba.ToList();
            viewModel.Tur= _context.Tur.ToList();
            viewModel.Marka = _context.Marka.ToList();
            return View(viewModel);
        }

        public IActionResult ArabaSil(int id)
        {
            var hayvan=_context.Araba.Find(id);
            _context.Araba.Remove(hayvan);
            _context.SaveChanges();
            return RedirectToAction("ArabaDuzenle", "Admin");
        }
        public IActionResult ArabaUpdate(int id)
        {
            var araba = _context.Araba.Find(id);
            var viewModel = new ArabaTurMarkaViewModel();
            viewModel.Turler = _context.Tur.ToList();
            viewModel.Markalar = _context.Marka.ToList();
            viewModel.Araba = araba;
            
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult ArabaUpdate(Araba araba,int id)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100);
            var hay = _context.Araba.Find(id);
            if (ModelState.IsValid)
            {
                if (Request.Form.Files.Count > 0)
                {
                    string dosyaAdi = Path.GetFileName(Request.Form.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Form.Files[0].FileName);
                    string dbAd = araba.Adi + araba.MarkaId.ToString() + araba.TurId.ToString() + araba.Model.ToString() + araba.EkBilgiler + sayi.ToString() + uzanti;
                    string yol = "wwwroot/img/" + dbAd; //+ uzanti;
                    using (FileStream fs = System.IO.File.Create(yol))
                    {
                        Request.Form.Files[0].CopyTo(fs);
                        fs.Flush();
                    }
                    hay.Foto = "/img/" + dbAd;
                    hay.Adi = araba.Adi;
                    hay.TurId = araba.TurId;
                    hay.MarkaId = araba.MarkaId;
                    hay.HasarliMi = araba.HasarliMi;
                    hay.EkBilgiler = araba.EkBilgiler;
                    hay.Model = araba.Model;
                    hay.RezerveMi = araba.RezerveMi;
                    hay.Marka = _context.Marka.Find(araba.MarkaId);
                    hay.Tur = _context.Tur.Find(araba.TurId);
                    _context.Araba.Update(hay);
                    _context.SaveChanges();
                    return RedirectToAction("ArabaDuzenle", "Admin");
                }
                else
                {
                    hay.Adi = araba.Adi;
                    hay.TurId = araba.TurId;
                    hay.MarkaId = araba.MarkaId;
                    hay.HasarliMi = araba.HasarliMi;
                    hay.EkBilgiler = araba.EkBilgiler;
                    hay.Model = araba.Model;
                    hay.RezerveMi = araba.RezerveMi;
                    hay.Marka = _context.Marka.Find(araba.Marka);
                    hay.Tur = _context.Tur.Find(araba.TurId);
                    _context.Araba.Update(hay);
                    _context.SaveChanges();
                    return RedirectToAction("ArabaDuzenle", "Admin");
                }
            }
            return RedirectToAction("ArabaDuzenle", "Admin");
        }
        public IActionResult TurEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TurEkle(Tur tur)
        {
            if (ModelState.IsValid)
            {
                _context.Tur.Add(tur);
                _context.SaveChanges();
                ViewBag.Mesaj = "Ekleme İşlemi Başarılı";
                return View();
            }
            ViewBag.Mesaj = "Ekleme İşlemi Başarısız.";
            return View();
        }
        public IActionResult TurDuzenle()
        {
            return View(_context.Tur.ToList());
        }
        [HttpPost]
        public IActionResult TurDuzenle(int id,string duzeltilmis)
        {
            if (ModelState.IsValid)
            {
                var tur = _context.Tur.Find(id);
                if(duzeltilmis != null)
                {
                    tur.TurAdi = duzeltilmis;
                    _context.Tur.Update(tur);
                    _context.SaveChanges();
                    ViewBag.Mesaj = "Düzenleme Başarılı";
                    return View(_context.Tur.ToList());
                }
                else
                {
                    ViewBag.Error = "Lütfen boş bırakmayın!";
                    return View(_context.Tur.ToList());
                }
            }
            return View(_context.Tur.ToList());
        }
        public IActionResult TurSil()
        {
            return View(_context.Tur.ToList());
        }
        [HttpPost]
        public IActionResult TurSil(int id)
        {
            if (ModelState.IsValid)
            {
                var tur=_context.Tur.Find(id);
                _context.Tur.Remove(tur);
                _context.SaveChanges();
                ViewBag.Mesaj = "Silme işlemi başarılı";
                return View(_context.Tur.ToList());
            }
            ViewBag.Error = "Silme işlemi başarısız";
            return View(_context.Tur.ToList());
        }
        public IActionResult MarkaEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MarkaEkle(Marka marka)
        {
            if (ModelState.IsValid)
            {
                _context.Marka.Add(marka);
                _context.SaveChanges();
                ViewBag.Mesaj = "Ekleme İşlemi Başarılı";
                return View();
            }
            ViewBag.Mesaj = "Ekleme İşlemi Başarısız.";
            return View();
        }
        public IActionResult MarkaDuzenle()
        {
            return View(_context.Marka.ToList());
        }
        [HttpPost]
        public IActionResult MarkaDuzenle(int id, string duzeltilmis)
        {
            if (ModelState.IsValid)
            {
                var cins = _context.Marka.Find(id);
                if (duzeltilmis != null)
                {
                    cins.MarkaAdi = duzeltilmis;
                    _context.Marka.Update(cins);
                    _context.SaveChanges();
                    ViewBag.Mesaj = "Düzenleme Başarılı";
                    return View(_context.Marka.ToList());
                }
                else
                {
                    ViewBag.Error = "Lütfen boş bırakmayın!";
                    return View(_context.Marka.ToList());
                }
            }
            return View(_context.Marka.ToList());
        }
        public IActionResult MarkaSil()
        {
            return View(_context.Marka.ToList());
        }
        [HttpPost]
        public IActionResult MarkaSil(int id)
        {
            if (ModelState.IsValid)
            {
                var cins = _context.Marka.Find(id);
                _context.Marka.Remove(cins);
                _context.SaveChanges();
                ViewBag.Mesaj = "Silme işlemi başarılı";
                return View(_context.Marka.ToList());
            }
            ViewBag.Error = "Silme işlemi başarısız";
            return View(_context.Marka.ToList());
        }
        public IActionResult Kullanicilar()
        {
            var kullanicilar = _context.Users.ToList();
            var userRoles = _context.UserRoles.ToList();
            for (int i = 0; i < kullanicilar.Count; i++)
            {
                for (int j = 0; j < kullanicilar.Count; j++)
                {
                    if (kullanicilar[i].Id == userRoles[j].UserId)
                    {
                        kullanicilar[i].Rol = userRoles[j].RoleId;
                        if (kullanicilar[i].Rol == "1")
                        {
                            kullanicilar[i].Rol = "Admin";
                        }
                        else
                        {
                            kullanicilar[i].Rol = "Üye";
                        }
                    }
                }
            }
            return View(kullanicilar);
        }
        public IActionResult RolDegistir(string id)
        {
            var userRole = _context.UserRoles.Where(x => x.UserId == id).FirstOrDefault();
            _context.UserRoles.Remove(userRole);
            _context.SaveChanges();
            if (userRole.RoleId == "1")
            {
                userRole.RoleId = "2";
            }
            else
            {
                userRole.RoleId = "1";
            }
            _context.UserRoles.Add(userRole);
            _context.SaveChanges();
            return RedirectToAction("Kullanicilar", "Admin");
        }
    }
}