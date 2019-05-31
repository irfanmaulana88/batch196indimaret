using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Indimaret.Repo;
using Indimaret.Model;

namespace Indimaret.Web.Controllers
{
    public class BarangController : Controller
    {
        //
        // GET: /Barang/
        public ActionResult Index()
        {
            return View(BarangRepo.GetAll());
        }
        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Save(Barang barang)
        {
            if (BarangRepo.Createbarang(barang))
            {
                return Json(new {Simpan="Berhasil"}, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }

 
        //BarangRepo barangRepo = new BarangRepo(); //nonstatic
        [HttpPost]
        public ActionResult Delete(int ID)
        {
            if (BarangRepo.Deletebarang(ID)) //non static if ( barangRepo.Deletebarang(ID))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Edit (int ID)
        {
            return PartialView("_Edit", BarangRepo.GetByID(ID));
        }

        public ActionResult EditSimpan(Barang barang)
        {
            if (BarangRepo.Editbarang(barang))
            {
                return Json(new { EditSimpan = "Berhasil" }, JsonRequestBehavior.AllowGet); //return json digunakan untuk memunculkan alert
            }
            else
            {
                return Json(new { EditSimpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}