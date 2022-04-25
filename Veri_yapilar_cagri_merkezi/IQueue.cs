
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_yapilar_cagri_merkezi
{
    public interface IQueue
    {
        void Push(Cagri cagri);
        Cagri Pop();
        Cagri Peek();
        Boolean IsEmpty();
        void ArayaEkle(Cagri cagri,int position);

        Boolean VarMi(int cagritanimlayiciNo);

        void InsertastFromMiddle(Cagri cagri);
        Cagri GetElement(int value);

        String DisplayQueue();
        
    }
}
