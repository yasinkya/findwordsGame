using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Yapımı_Ödev
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void btnRandom_Click_1(object sender, EventArgs e)
        {
            cbxEnable(false);
            clearBx();
            cbx_letterJok.Enabled = true;
            cbx_letter1.Text = RndHarf();
            cbx_letter2.Text = RndHarf();
            cbx_letter3.Text = RndHarf();
            cbx_letter4.Text = RndHarf();
            cbx_letter5.Text = RndHarf();
            cbx_letter6.Text = RndHarf();
            cbx_letter7.Text = RndHarf();
            cbx_letter8.Text = RndHarf();
        }
        private void btnHgir_Click_1(object sender, EventArgs e)
        {
            cbxEnable(true);
            clearBx();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (cbx_letter1.SelectedIndex == -1)
            {
                MessageBox.Show("Harf 1 girilmemiş");
            }
            else if (cbx_letter2.SelectedIndex == -1)
            {
                MessageBox.Show("Harf 2 girilmemiş");
            }
            else if (cbx_letter3.SelectedIndex == -1)
            {
                MessageBox.Show("Harf 3 girilmemiş");
            }
            else if (cbx_letter4.SelectedIndex == -1)
            {
                MessageBox.Show("Harf 4 girilmemiş");
            }
            else if (cbx_letter5.SelectedIndex == -1)
            {
                MessageBox.Show("Harf 5 girilmemiş");
            }
            else if (cbx_letter6.SelectedIndex == -1)
            {
                MessageBox.Show("Harf 6 girilmemiş");
            }
            else if (cbx_letter7.SelectedIndex == -1)
            {
                MessageBox.Show("Harf 7 girilmemiş");
            }
            else if (cbx_letter8.SelectedIndex == -1)
            {
                MessageBox.Show("Harf 8 girilmemiş");
            }
            else
            {
                cbxEnable(false);
                string gelenHarfler = "";
                gelenHarfler = harfTut(gelenHarfler);

                kelimeAra kelimeara = new kelimeAra(gelenHarfler);  //gelen harflerin tutulacağı constructor metodlu class oluşturulur
                string getStr = kelimeara.ara();
                if (getStr == null) //classda kelime araması yapıldıktan sonra geri dönüş değerine göre konrol edilir
                {
                    MessageBox.Show("Bulunamdı");
                }
                else //herhangi bir kelime veri tabanında bulundu ise
                {
                    KontrolVePuanlama kntP = new KontrolVePuanlama(this.lbxBulunanlar, getStr);
                    int puan = kntP.Puanla();
                    if (puan == 0) //kontrol classında daha önceden aynı kelimeden puan alınmaması için kontrol edilir 
                    {
                        MessageBox.Show("Bu kombinasyondaki harflerle yeni puan kazanamadınız. Harfleri Değiştiriniz");
                    }
                    else 
                    {
                        MessageBox.Show("Bulunan Kelime = " + getStr+"\n"+ puan.ToString() + " Puan Kazandınız!");
                        lblPuan.Text = (Convert.ToInt32(lblPuan.Text) + puan).ToString();
                        lbxBulunanlar.Items.Add(getStr+"\t\t: "+puan.ToString()+" Puan");

                    }
                }
            }
        }

        //Harfleri bir string ifade içerisinde tutma
        private string harfTut(string gelenHarfler)
        {
            gelenHarfler += cbx_letter1.Text;
            gelenHarfler += cbx_letter2.Text;
            gelenHarfler += cbx_letter3.Text;
            gelenHarfler += cbx_letter4.Text;
            gelenHarfler += cbx_letter5.Text;
            gelenHarfler += cbx_letter6.Text;
            gelenHarfler += cbx_letter7.Text;
            gelenHarfler += cbx_letter8.Text;

            if (cbx_letterJok.SelectedIndex != -1)
            {
                gelenHarfler += cbx_letterJok.Text;
            }
            return gelenHarfler;
        }

        //Random Türkçe karakterli bir harf üretme
        Random rnd = new Random();  //fonksiyonun içerisinde yazıldığında random her defasında aynı değeri vermemesi için dışarıda  
        private string RndHarf()
        {
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
            char hrf = harfler[rnd.Next(harfler.Length)];

            return hrf.ToString();
        }


        //boxlara erişim fonksiyonu; kullanıcı girişli olacaksa aktif random olacaksa pasif
        private void cbxEnable(bool a)
        {

            if (a == true)
            {
                cbx_letter1.Enabled = true;
                cbx_letter2.Enabled = true;
                cbx_letter3.Enabled = true;
                cbx_letter4.Enabled = true;
                cbx_letter5.Enabled = true;
                cbx_letter6.Enabled = true;
                cbx_letter7.Enabled = true;
                cbx_letter8.Enabled = true;
            }
            else if (a == false)
            {
                cbx_letter1.Enabled = false;
                cbx_letter2.Enabled = false;
                cbx_letter3.Enabled = false;
                cbx_letter4.Enabled = false;
                cbx_letter5.Enabled = false;
                cbx_letter6.Enabled = false;
                cbx_letter7.Enabled = false;
                cbx_letter8.Enabled = false;
            }
        }

        //boxların içini temizleme
        private void clearBx()
        {
            cbx_letter1.SelectedIndex = -1;
            cbx_letter2.SelectedIndex = -1;
            cbx_letter3.SelectedIndex = -1;
            cbx_letter4.SelectedIndex = -1;
            cbx_letter5.SelectedIndex = -1;
            cbx_letter6.SelectedIndex = -1;
            cbx_letter7.SelectedIndex = -1;
            cbx_letter8.SelectedIndex = -1;
            cbx_letterJok.SelectedIndex = -1;
        }

        private void form2_Load(object sender, EventArgs e)
        {

        }
    }
}
