using Reservasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reservasi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ReservasiEntities db = new ReservasiEntities();
            tblT_Reservasi reservasi = new tblT_Reservasi();

            ReservasiViewModel reservasiViewModel = new ReservasiViewModel();

            reservasiViewModel.Reservasi_PK = reservasi.Reservasi_PK;
            reservasiViewModel.Ruangan_FK = reservasi.Ruangan_FK;
            reservasiViewModel.SubjectReservasi = reservasi.SubjectReservasi;
            reservasi.TanggalReservasi = reservasi.TanggalReservasi;
            reservasiViewModel.JamMulai = reservasi.JamMulai;
            reservasiViewModel.JamSelesai = reservasi.JamSelesai;
            reservasiViewModel.CreatedBy = reservasi.CreatedBy;
            reservasiViewModel.CreatedDate= reservasi.CreatedDate;
            reservasiViewModel.UpdatedDate= reservasi.UpdatedDate;
            reservasiViewModel.UpdatedBy= reservasi.UpdatedBy;

            return View(reservasiViewModel);
        }

        public ActionResult About()
        {
            ReservasiEntities db = new ReservasiEntities();
            tblT_Reservasi reservasi = new tblT_Reservasi();

            ReservasiViewModel reservasiViewModel = new ReservasiViewModel();

            reservasiViewModel.Reservasi_PK = reservasi.Reservasi_PK;
            reservasiViewModel.Ruangan_FK = reservasi.Ruangan_FK;
            reservasiViewModel.SubjectReservasi = reservasi.SubjectReservasi;
            reservasi.TanggalReservasi = reservasi.TanggalReservasi;
            reservasiViewModel.JamMulai = reservasi.JamMulai;
            reservasiViewModel.JamSelesai = reservasi.JamSelesai;
            reservasiViewModel.CreatedBy = reservasi.CreatedBy;
            reservasiViewModel.CreatedDate = reservasi.CreatedDate;
            reservasiViewModel.UpdatedDate = reservasi.UpdatedDate;
            reservasiViewModel.UpdatedBy = reservasi.UpdatedBy;

            return View(reservasiViewModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}