
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_Neset_Goktug_Gorukoglu
{


    public class Bahis_Bilgileri
    {
        public Guid BBid { get; set; }
        public Guid IBid { get; set; }
        public string bahis_yapan { get; set; }
        public string bahis_miktari { get; set; }
        public DateTime bahis_tarihi { get; set; }
        public string bahis_durumu { get; set; }


    }
}
