using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_Neset_Goktug_Gorukoglu
{


    public class Iddia_Bilgileri
    {
        public List<Bahis_Bilgileri> Bahis { get; set; }
        public Guid IBid { get; set; }
        public string konu { get; set; }
        public string aciklama { get; set; }
        public DateTime tarih { get; set; }
        public string sahip { get; set; }
        public string durum { get; set; }
    }
}
