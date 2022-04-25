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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int sayac = 0;
        

        public MusteriTemsilcisi ticari1 = new MusteriTemsilcisi();
        public MusteriTemsilcisi ticari2 = new MusteriTemsilcisi();
        public MusteriTemsilcisi bireysel1 = new MusteriTemsilcisi();
        public MusteriTemsilcisi bireysel2 = new MusteriTemsilcisi();

        String[] notlarDizisi = { "iyi bir insan", "borçları var", "şikayet ediyor", "maaş yatmaması durumundan şikayetçi", "kredi istiyor" };
        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lblSaat.Text = DateTime.Now.ToString("hh:mm tt");
            
        }
        public Form2 form2 = new Form2();
        private void button7_Click(object sender, EventArgs e)
        {
            for(int i = bireysel1.cagrilar.front; i < bireysel1.cagrilar.rear; i++)
            {
                form2.b1.cagrilar.Push(bireysel1.cagrilar.Pop());
            }
            for (int i = bireysel2.cagrilar.front; i < bireysel2.cagrilar.rear; i++)
            {
                form2.b2.cagrilar.Push(bireysel2.cagrilar.Pop());
            }
            for (int i = ticari1.cagrilar.front; i < ticari1.cagrilar.rear; i++)
            {
                form2.t1.cagrilar.Push(ticari1.cagrilar.Pop());
            }
            for (int i = ticari2.cagrilar.front; i < ticari2.cagrilar.rear; i++)
            {
                form2.t2.cagrilar.Push(ticari2.cagrilar.Pop());
            }
            form2.Show();           
        }

        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            sayac++;
            if (radioButton1.Checked == true)
            {
                Müsteri musteri = new Müsteri {
                    tanimlayici = sayac,
                    tur = "Bireysel"
                };
                Cagri aramaCagrisi = new Cagri
                {
                    cagriTanimlayicisi = sayac,
                    musteri = musteri,
                    aramaZamani = DateTime.Now.ToString("hh:mm tt"),
                    alininNot = notlarDizisi[random.Next(0, notlarDizisi.Length)]
                };
                bireysel1.cagrilar.Push(aramaCagrisi);
                form2.aramaSayisi++;
                lboxAramalar.Items.Add("Tanımlıyıcı No:" + aramaCagrisi.cagriTanimlayicisi + " | Arama Zamanı:" + aramaCagrisi.aramaZamani + " | " + aramaCagrisi.sira + ". sıradasınız");
                MessageBox.Show("Arama işlemini gerçekleşmiştir. Birazdan Yönlendirileceksiniz.");
            }

            else if (radioButton2.Checked == true)
            {
                Müsteri musteri = new Müsteri
                {
                    tanimlayici = sayac,
                    tur = "Ticari"
                };
                Cagri aramaCagrisi = new Cagri
                {
                    cagriTanimlayicisi = sayac,
                    musteri = musteri,
                    aramaZamani = DateTime.Now.ToString("hh:mm tt"),
                    alininNot = notlarDizisi[random.Next(0, notlarDizisi.Length)]
                };
                ticari1.cagrilar.Push(aramaCagrisi);
                form2.aramaSayisi++;
                lboxAramalar.Items.Add("Tanımlıyıcı No:" + aramaCagrisi.cagriTanimlayicisi + " | Arama Zamanı:" + aramaCagrisi.aramaZamani + " | " + aramaCagrisi.sira + ". sıradasınız");
                MessageBox.Show("Arama işlemini gerçekleşmiştir. Birazdan Yönlendirileceksiniz.");
            }

            else if (radioButton3.Checked == true)
            {
                Müsteri musteri = new Müsteri {
                    tanimlayici = sayac,
                    tur = "Bireysel"
                };
                Cagri aramaCagrisi = new Cagri
                {
                    cagriTanimlayicisi = sayac,
                    musteri = musteri,
                    aramaZamani = DateTime.Now.ToString("hh:mm tt"),
                    alininNot = notlarDizisi[random.Next(0, notlarDizisi.Length)]
                };
                bireysel2.cagrilar.Push(aramaCagrisi);
                form2.aramaSayisi++;
                lboxAramalar.Items.Add("Tanımlıyıcı No:" + aramaCagrisi.cagriTanimlayicisi + " | Arama Zamanı:" + aramaCagrisi.aramaZamani + " | " + aramaCagrisi.sira + ". sıradasınız");
                MessageBox.Show("Arama işlemini gerçekleşmiştir. Birazdan Yönlendirileceksiniz.");
            }

            else if (radioButton4.Checked == true)
            {
                Müsteri musteri = new Müsteri
                {
                    tanimlayici = sayac,
                    tur = "Ticari"
                };
                Cagri aramaCagrisi = new Cagri
                {
                    cagriTanimlayicisi = sayac,
                    musteri = musteri,
                    aramaZamani = DateTime.Now.ToString("hh:mm tt"),
                    alininNot = notlarDizisi[random.Next(0, notlarDizisi.Length)]
                 };
                ticari2.cagrilar.Push(aramaCagrisi);
                form2.aramaSayisi++;
                lboxAramalar.Items.Add("Tanımlıyıcı No:" + aramaCagrisi.cagriTanimlayicisi + " | Arama Zamanı:" + aramaCagrisi.aramaZamani + " | " + aramaCagrisi.sira + ". sıradasınız");
                MessageBox.Show("Arama işlemini gerçekleşmiştir. Birazdan Yönlendirileceksiniz.");
            }

            else
            {
                MessageBox.Show("Lütfen bir Müşteri temsilcisi seçiniz!!!");
            }
        }

        private void btnTicari1cata_Click(object sender, EventArgs e)
        {
            Cagri CikanCagri = ticari1.cagrilar.Peek();
            CikanCagri.baslangicZaman = DateTime.Now;
            lblTicari1uygunluk.Text = CikanCagri.cagriTanimlayicisi + " ile görüşüyor.";
        }

        private void btnTicari2cata_Click(object sender, EventArgs e)
        {
            Cagri CikanCagri = ticari2.cagrilar.Pop();
            lblTicari2uygunluk.Text = CikanCagri.cagriTanimlayicisi + " ile görüşüyor.";
        }

        private void btnBireysel1cata_Click(object sender, EventArgs e)
        {
            Cagri CikanCagri = bireysel1.cagrilar.Pop();
            lblBireysel1uygunluk.Text = CikanCagri.cagriTanimlayicisi + " ile görüşüyor.";
        }

        private void btnBireysel2cata_Click(object sender, EventArgs e)
        {
            Cagri CikanCagri = bireysel2.cagrilar.Pop();
            lblBireysel2uygunluk.Text = CikanCagri.cagriTanimlayicisi + " ile görüşüyor.";
        }
        
        
        private void btTicari1cbitir_Click(object sender, EventArgs e)
        {
            Cagri CikanCagri = ticari1.cagrilar.Pop();
            CikanCagri.bitisZaman = DateTime.Now;
            CikanCagri.cagriZamanBilgisi = (CikanCagri.bitisZaman - CikanCagri.baslangicZaman).Minutes.ToString();
            lblTicari1uygunluk.Text = "Uygun";
        }

        private void btTicari2cbitir_Click(object sender, EventArgs e)
        {
            Cagri CikanCagri = ticari2.cagrilar.Pop();
            CikanCagri.bitisZaman = DateTime.Now;
            CikanCagri.cagriZamanBilgisi = (CikanCagri.bitisZaman - CikanCagri.baslangicZaman).Minutes.ToString();
            CikanCagri.alininNot = notlarDizisi[random.Next(0, notlarDizisi.Length)];
            lblTicari2uygunluk.Text = "Uygun";
        }

        private void btnBireysel1cbitir_Click(object sender, EventArgs e)
        {
            Cagri CikanCagri = bireysel1.cagrilar.Pop();
            CikanCagri.bitisZaman = DateTime.Now;
            CikanCagri.cagriZamanBilgisi = (CikanCagri.bitisZaman - CikanCagri.baslangicZaman).Minutes.ToString();
            CikanCagri.alininNot = notlarDizisi[random.Next(0, notlarDizisi.Length)];
            lblBireysel1uygunluk.Text = "Uygun";
        }

        private void btnBireysel2cbitir_Click(object sender, EventArgs e)
        {
            Cagri CikanCagri = bireysel2.cagrilar.Pop();
            CikanCagri.bitisZaman = DateTime.Now;
            CikanCagri.cagriZamanBilgisi = (CikanCagri.bitisZaman - CikanCagri.baslangicZaman).Minutes.ToString();
            CikanCagri.alininNot = notlarDizisi[random.Next(0, notlarDizisi.Length)];
            lblBireysel2uygunluk.Text = "Uygun";
        }
        public int tempIndex = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if(cmboxtur.SelectedItem.ToString() == "Ticari1")
            {
                if (ticari1.cagrilar.VarMi(Convert.ToInt32(txtdirekttanNo.Text)))
                {
                    Cagri temp = ticari1.cagrilar.GetElement(Convert.ToInt32(txtdirekttanNo.Text));
                    ticari1.cagrilar.InsertastFromMiddle(temp);
                }
                else
                {
                    MessageBox.Show("Böyle Tanımlıyıcı bir Çağrı bulunmamaktadir.");
                }
            }
            else if(cmboxtur.SelectedItem.ToString() == "Ticari2")
            {
                if (ticari2.cagrilar.VarMi(Convert.ToInt32(txtdirekttanNo.Text)))
                {
                    Cagri temp = ticari2.cagrilar.GetElement(Convert.ToInt32(txtdirekttanNo.Text));
                    ticari2.cagrilar.InsertastFromMiddle(temp);
                    MessageBox.Show(ticari1.cagrilar.DisplayQueue());
                }
                else
                {
                    MessageBox.Show("Böyle Tanımlıyıcı bir Çağrı bulunmamaktadir.");
                }
            }
            else if(cmboxtur.SelectedItem.ToString() == "Bireysel1")
            {
                if (bireysel1.cagrilar.VarMi(Convert.ToInt32(txtdirekttanNo.Text)))
                {
                    Cagri temp = bireysel1.cagrilar.GetElement(Convert.ToInt32(txtdirekttanNo.Text));
                    bireysel1.cagrilar.InsertastFromMiddle(temp);
                }
                else
                {
                    MessageBox.Show("Böyle Tanımlıyıcı bir Çağrı bulunmamaktadir.");
                }
            }
            else if(cmboxtur.SelectedItem.ToString() == "Bireysel2")
            {
                if (bireysel2.cagrilar.VarMi(Convert.ToInt32(txtdirekttanNo.Text)))
                {
                    Cagri temp = bireysel2.cagrilar.GetElement(Convert.ToInt32(txtdirekttanNo.Text));
                    bireysel2.cagrilar.InsertastFromMiddle(temp);
                }
                else
                {
                    MessageBox.Show("Böyle Tanımlıyıcı bir Çağrı bulunmamaktadir.");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cagri temp = new Cagri
            {
                cagriTanimlayicisi = 1001,
                alininNot = "güzel "
            };
            label10.Text = "Yükleme Başarılı";
        }
    }
}
