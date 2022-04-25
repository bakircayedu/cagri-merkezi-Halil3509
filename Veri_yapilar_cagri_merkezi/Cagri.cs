using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_yapilar_cagri_merkezi
{
    public class Cagri:Arama
    {
        public int cagriTanimlayicisi { get; set; }
        public String cagriZamanBilgisi{ get; set; }
        public DateTime baslangicZaman{ get; set; }
        public DateTime bitisZaman { get; set; }
        public int sira { get; set; }

        public MusteriTemsilcisi musteriTemsilcisi;

        public Müsteri musteri = new Müsteri();
        public String alininNot { get; set; }


    }
}
