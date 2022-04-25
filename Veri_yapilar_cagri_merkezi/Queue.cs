using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_yapilar_cagri_merkezi
{
    public class Queue : IQueue
    {
        Cagri[] queue;

        private int size = 0;
        public int count = 0;
        private int eylem = 0;
        public int front = -1;
        public int rear = -1;

        public Queue(int itemSize)
        {
            this.size = itemSize;
            queue = new Cagri[size];
        }

        public void ArayaEkle(Cagri cagri,int position)
        {
            Cagri eklenecekCagri = cagri;
            for(int i = queue.Length-1; i < position; i--)
            {
                Cagri temp = queue[i];
                queue[i] = queue[i - 1];
                queue[i - 1] = temp;
            }
            count++;

        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public Cagri Peek()
        {
            if (IsEmpty())
                throw new Exception("Liste Boştur");
            return queue[front];       
        }

        public Cagri Pop()
        {
            if (IsEmpty())
                throw new Exception("Liste Boştur");
            else
            {
                Cagri temp = queue[front];
                queue[front++] = null;
                count--;
                eylem++;
                return temp;
            }
        }

        public void Push(Cagri cagri)
        {
            if((rear == size-1) || (count == size))
            {
                throw new Exception("Liste Doludur.");
            }
            if(front == -1)
            {
                front = 0;
            }
            queue[++rear] = cagri;
            queue[rear].sira = rear + 1;
            count++;
            
        }
        private void SiraYenileme()
        {
            for(int i = front; i <= rear; i++)
            {
                queue[i].sira--;
            }
        }


        public Boolean VarMi(int cagritanimlayiciNo)
        {
            for(int i = front; i <= rear; i++)
            {
                if(queue[i].cagriTanimlayicisi == cagritanimlayiciNo)
                {
                    return true;                 
                }
            }
            return false;
        }

        public void InsertastFromMiddle(Cagri cagri)
        {
            for (int i = cagri.sira-1; i > front; i--)
            {
                Cagri temp = queue[i];
                queue[i] = queue[i-1];
                queue[i-1] = temp;
            }
            MessageBox.Show("Ekleme işleminiz başarılı");
        }

        public Cagri GetElement(int value)
        {
            for(int i = front; i<= rear; i++)
            {
                if(queue[i].cagriTanimlayicisi == value)
                {
                    return queue[i];
                }
            }
            // İts writen Rnndom. not effectively this area
            return queue[front];
        }

        public string DisplayQueue()
        {
            String result = "";
            for(int i = front; i < count-1; i++)
            {
                result += queue[i].cagriTanimlayicisi + "-";
            }
            return result;
        }
    }
}
