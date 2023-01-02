using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HayvanBarinagiCalisma.Models;
using HayvanBarinagiCalisma.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Localization;

namespace HayvanBarinagiCalisma.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context,IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _context = context;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Hakkimizda()
        {
            //ViewData["BizKimiz"] = _localizer.GetString("BizKimiz");
            return View();
        }
        public IActionResult Iletisim()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Iletisim(Iletisim iletisim)
        {
            if (ModelState.IsValid)
            {
                iletisim.Tarih = DateTime.Now;
                _context.Iletisim.Add(iletisim);
                _context.SaveChanges();
                return RedirectToAction("Iletisim");
            }
            
            return View();
        }
        public IActionResult Rezerve()
        {
            var viewModel = new ArabalarTurMarkaViewModel();
            viewModel.Araba = _context.Araba.Where(x=>x.RezerveMi==false).ToList();
            viewModel.Tur = _context.Tur.ToList();
            viewModel.Marka = _context.Marka.ToList();
            return View(viewModel);
        }
        [Authorize(Roles ="Admin,Uye")]
        public IActionResult RezerveDetay(int id)
        {
            var hayvan = _context.Araba.Find(id);
            var tur = _context.Tur.Where(x => x.TurId == hayvan.TurId).FirstOrDefault();
            ViewBag.Turu = tur.TurAdi;
            var cins = _context.Marka.Where(x => x.MarkaId == hayvan.MarkaId).FirstOrDefault();
            ViewBag.Cinsi = cins.MarkaAdi;
            return View(hayvan);
        }
        [Authorize(Roles = "Admin,Uye")]
        public IActionResult RezerveGercekleme(int id)
        {
            var hayvan = _context.Araba.Find(id);
            hayvan.RezerveMi = true;
            _context.Araba.Update(hayvan);
            _context.SaveChanges();
            return View(hayvan);
        }
        public IActionResult TurDetay(int id) {
            var viewModel = new ArabalarTurMarkaViewModel();
            viewModel.Araba = _context.Araba.Where(x => x.RezerveMi == false && x.TurId==id).ToList();
            viewModel.Tur = _context.Tur.ToList();
            viewModel.Marka = _context.Marka.ToList();
            return View(viewModel);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
