using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservasi.Models
{
    public class ReservasiViewModel
    {
        public int Reservasi_PK { get; set; }
        public Nullable<int> Ruangan_FK { get; set; }
        public string SubjectReservasi { get; set; }
        public Nullable<System.DateTime> TanggalReservasi { get; set; }
        public Nullable<System.TimeSpan> JamMulai { get; set; }
        public Nullable<System.TimeSpan> JamSelesai { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}