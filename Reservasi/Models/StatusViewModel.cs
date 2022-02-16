using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservasi.Models
{
    public class StatusViewModel
    {
        public int Status_PK { get; set; }
        public string NamaStatus { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}