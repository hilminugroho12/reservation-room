using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservasi.Models
{
    public class RuanganViewModel
    {
        public int Ruangan_PK { get; set; }
        public string NamaRuangan { get; set; }
        public Nullable<int> Lantai { get; set; }
        public Nullable<int> DayaTampung { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> Status_FK { get; set; }
    }
}