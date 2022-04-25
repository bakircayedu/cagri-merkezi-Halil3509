using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_yapilar_cagri_merkezi
{
    public class MusteriTemsilcisi
    {
        public int tanimlayici { get; set; }
        public String calistigiAlan { get; set; }
        public Boolean uygunluk { get; set; }

        public Queue cagrilar = new Queue(100);
    }
}
