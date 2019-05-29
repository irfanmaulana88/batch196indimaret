using Indimaret.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indimaret.Web.Controllers
{
    public class TransactionController : Controller
    {
        // GET: Transaction
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sample()
        {
            return View();
        }
        public ActionResult Tampil()
        {
            return Json(BarangRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }

    }
}