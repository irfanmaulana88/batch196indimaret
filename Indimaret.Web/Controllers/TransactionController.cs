using Indimaret.Repo;
using Indimaret.ViewModel;
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

        [HttpPost]
        public ActionResult SaveTransaction(TransactionViewModel mdl)
        {
            if (TransactionRepo.SimpanTransaksi(mdl))
            {
                return Json(new { hasil = "Berhasil" }, JsonRequestBehavior.AllowGet); //return json digunakan untuk memunculkan alert
            }
            else
            {
                return Json(new { hasil = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}