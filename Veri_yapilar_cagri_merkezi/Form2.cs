using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_yapilar_cagri_merkezi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int aramaSayisi;

        public MusteriTemsilcisi b1 = new MusteriTemsilcisi();
        public MusteriTemsilcisi b2 = new MusteriTemsilcisi();
        public MusteriTemsilcisi t1 = new MusteriTemsilcisi();
        public MusteriTemsilcisi t2 = new MusteriTemsilcisi();
        private void Form2_Load(object sender, EventArgs e)
        {
            lboxGunlukRapor.Items.Add("Gün:" + DateTime.Now.ToString("MM/dd/yyyy") + " = " + aramaSayisi);
            for(int i = b1.cagrilar.front; i < b1.cagrilar.rear; i++)
            {
                lboxAlinanNotlar.Items.Add(b1.cagrilar.Pop().alininNot);
            }   
            for(int i = b2.cagrilar.front; i< b2.cagrilar.rear; i++)
            {
                lboxAlinanNotlar.Items.Add(b2.cagrilar.Pop().alininNot);
            }
            for(int i = t1.cagrilar.front; i < t1.cagrilar.rear; i++)
            {
                lboxAlinanNotlar.Items.Add(t1.cagrilar.Pop().alininNot);
            }
            for(int i = t2.cagrilar.front; i< t2.cagrilar.rear; i++)
            {
                lboxAlinanNotlar.Items.Add(t2.cagrilar.Pop().alininNot);
            }
            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            String aranan = txtarama.Text;
            String ifade = lboxAlinanNotlar.Text;
            lboxAlinanNotlar.Items.Clear();
            lboxAlinanNotlar.Items.Add(kontrol(ifade, aranan));

        }
        static String kontrol(string metin, string joker)
        {
            String result = "";
            string[] kelimeler = metin.Split(' ');
            foreach (string kelime in kelimeler)
            {
                if (DesenAra(joker, kelime) == true)
                {
                    result += kelime +" \n";
                }

            }
            return result;
        }
        static Boolean DesenAra(String desen, String kelime)
        {
            if (String.Compare(desen, kelime) == 0)
            {
                return true;
            }
            else if (String.IsNullOrEmpty(kelime))
            {
                if (String.IsNullOrEmpty(desen.Trim(new Char[1] { '*' })))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (desen.Length == 0)
            {
                return false;
            }
            else if (desen[0] == '-')
            {
                return DesenAra(desen.Substring(1), kelime.Substring(1));
            }
            else if (desen[desen.Length - 1] == '-')
            {
                return DesenAra(desen.Substring(0, desen.Length - 1), kelime.Substring(0, kelime.Length - 1));
            }
            else if (desen[0] == '*')
            {
                if (DesenAra(desen.Substring(1), kelime))
                {
                    return true;
                }
                else
                {
                    return DesenAra(desen, kelime.Substring(1));
                }
            }
            else if (desen[desen.Length - 1] == '*')
            {
                if (DesenAra(desen.Substring(0, desen.Length - 1), kelime))
                {
                    return true;
                }
                else
                {
                    return DesenAra(desen, kelime.Substring(0, kelime.Length - 1));
                }
            }
            else if (desen[0] == kelime[0])
            {
                return DesenAra(desen.Substring(1), kelime.Substring(1));
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
