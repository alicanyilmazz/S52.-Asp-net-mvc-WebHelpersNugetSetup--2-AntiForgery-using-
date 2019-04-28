using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHelpersNugetKurulumu.Models;

namespace WebHelpersNugetKurulumu.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        [HttpGet]
        public ActionResult Test()
        {
            return View(SampleDatabase.datas);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]  //AntiForgeryToken kontrolunu saglar.
        public ActionResult Test(int id)
        {
            SampleDatabase.datas.RemoveAt(id);
            return RedirectToAction("Test");
        }       
        public ActionResult FakeTest()
        {
            return View();
        }

    }
}