using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

//using System.Globalization;
//(new CultureInfo("tr-TR", false)) - toupper Türkçe karakter desteği

namespace Yazılım_Yapımı_Ödev
{
    public partial class Kelime_İşlem : Form
    {
        public Kelime_İşlem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string gelenHarfler;

        private void btnHgir_Click(object sender, EventArgs e)
        {
            cbxEnable(true);
            clearBx();
            btnTahmin.Enabled = true;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            cbxEnable(false);
            clearBx();
            cbx_letterJok.Enabled = true;
            btnTahmin.Enabled = true;
            tbxKelime.Enabled = false;
            btnCheck.Enabled = false;

            cbx_letter1.Text = RndHarf();
            cbx_letter2.Text = RndHarf();
            cbx_letter3.Text = RndHarf();
            cbx_letter4.Text = RndHarf();
            cbx_letter5.Text = RndHarf();
            cbx_letter6.Text = RndHarf();
            cbx_letter7.Text = RndHarf();
            cbx_letter8.Text = RndHarf();

        }

        //Kelime tahmininde bulunmadan önce boxların içerisini kontrol eder
        private void button1_Click(object sender, EventArgs e)
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
                gelenHarfler = "";
                harfTut();
                tbxKelime.Enabled = true;
                btnCheck.Enabled = true;
            }

        }

        //Harfleri bir string ifade içerisinde tutma
        private void harfTut()
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
        }

        //Random Türkçe karakterli bir harf üretme
        Random rnd = new Random();  //fonksiyonun içerisinde yazıldığında random her defasında aynı değeri vermemesi için dışarıda  
        private string RndHarf()
        {
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
            char hrf = harfler[rnd.Next(harfler.Length)];

            return hrf.ToString();
        }

        //Girilen kelimenin harfleri gelen harflere göre kontrol edilir
        private void harf_kontrol(string kontrol_harf, string kelime)
        {
            char[] tahmin = kelime.ToCharArray();
            char[] gelen = kontrol_harf.ToCharArray();

            LinkedList<char> LLgelen = new LinkedList<char>();
            LLgelen.AddFirst(gelen[0]);

            for (int a = 1; a < kontrol_harf.Length; a++)
            {
                LLgelen.AddLast(gelen[a]);
            }
            //gelen harfler linked listte tutuldu, kontrol LLgelen'den yapılıp kullanılan harfin tekrar kullanılmaması engellenecek

            bool snc = true;
            int temp = kontrol_harf.Length;
            char bulunamayan = ' ';

            for (int i = 0; i < kelime.Length; i++)
            {
                for (int j = 0; j < temp; j++)
                {

                    if (tahmin[i] != LLgelen.ElementAt(j))
                    {
                        if (j == temp - 1) //***
                        {
                            snc = false;
                            bulunamayan = tahmin[i];
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (tahmin[i] == LLgelen.ElementAt(j))  //harf bulundu ise lilnkedlistten o harf kaldırılır sıradaki harf için döngüye girer
                    {
                        temp--;
                        LLgelen.Remove(LLgelen.ElementAt(j));
                        break;
                    }
                }
                if (snc == false) // *** yerde; kelimedeki i. harf gelen hafler içerisinde bulunamdı ve sona gelindi ise döngü kırılır
                {
                    MessageBox.Show("Kelimenizdeki '" + bulunamayan.ToString() + "' harfi gelen harfler içerisinde bulunamadı ");
                    break;
                }

                if (i == kelime.Length - 1) // döngü tamamlanıp bu kısma gelindiğinde tüm harfler karşılaştırılmış olup hepsi de bulunmaktadır
                {
                    kelime_kontrol(kelime, kelime.Length); //harf kontrolu yapıldı kelime veri tabanında kontrol edilecek
                }
            }
        }

        //Dosyalardan kelimeler okuma ve karşılaştırma fonksiyonu
        private void kelime_kontrol(string aranan, int l_lenght)
        {
            string fileLoc = "";
            string dosya = "";
            switch (l_lenght)
            {
                case 3:
                    dosya = "3letters.txt";
                    break;
                case 4:
                    dosya = "4letters.txt";
                    break;
                case 5:
                    dosya = "5letters.txt";
                    break;
                case 6:
                    dosya = "6letters.txt";
                    break;
                case 7:
                    dosya = "7letters.txt";
                    break;
                case 8:
                    dosya = "8letters.txt";
                    break;
                case 9:
                    dosya = "9letters.txt";
                    break;
            }

            fileLoc = @"C:\Users\Kaya\Desktop\projects\cs_p\Kelime Bulma c# - proje dizini\words\" + dosya;

            FileStream fs = new FileStream(fileLoc, FileMode.Open, FileAccess.Read);  //dosya okuma modunda açıldı
            StreamReader sw = new StreamReader(fs);

            string temp = sw.ReadLine();  //okuyucudan ilk satır okunur

            while (true)
            {
                if (temp[0] != aranan[0])  //Aranan kelimenin ilk harfi ne ise o harfle başlayan kelimelerin olduğu satırı okur
                {
                    temp = sw.ReadLine();
                    continue;
                }
                else
                {
                    bool bulundu = false;
                    char[] toTrim = { ',', ' ' };  //okunan satırdaki istenmeyen karakterler atılır
                    string[] ayrılmışkelimeler = temp.Split(toTrim);  //ardından kelimeler diziye aktarılır

                    for (int i = 0; i < ayrılmışkelimeler.Length; i++)  //oluşturulan dizide kelimeyi arama
                    {
                        if (aranan == ayrılmışkelimeler[i].TrimEnd(toTrim).ToUpper((new CultureInfo("tr-TR", false))))
                        {
                            bulundu = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (bulundu == true)  //kelime bulundu ise
                    {
                        if (bulunanlar(aranan) == true)  //Daha önce bulunmuş mu kontrol edilir
                        {
                            MessageBox.Show("Tahminde bulunduğunuz; '" + aranan + "' kelimesini daha önce buldunuz...");
                            break;
                        }
                        else
                        {
                            int puan = Puanla(aranan.Length);
                            MessageBox.Show("Kelime Tahmininiz Doğru: " + aranan + "\n" + puan.ToString() + " Puan Kazandınız.");
                            lbxBulunanlar.Items.Add(aranan + "\t:   " + puan.ToString()+" Puan");
                            break;
                        }
                    }
                    else //kelime bulunmadı ise sonraki satıra (sıradaki satır ilk harfine göre aynı ise) geçer 
                    {
                        temp = sw.ReadLine();
                        if (temp[0] == aranan[0])
                        {
                            continue;
                        }
                        else 
                        {
                            MessageBox.Show("Kelime= '" + aranan + "' bulunamadı puan kazanamadınız");
                            break;
                        }

                    }

                }

            }
            fs.Close();
            sw.Close();
        }

        //doğru tahminde bulunulan kelimelerden birden fazla puan alınmaması için tutulup kontrol edildiği fonk
        LinkedList<string> kelime = new LinkedList<string>();
        private bool bulunanlar(string bulunan_K)
        {
            kelime.AddFirst("aaa");
            bool kontrol = false;
            for (int i = 0; i < kelime.Count; i++)
            {
                if (kelime.ElementAt(i) == bulunan_K)
                {
                    kontrol = true;
                }
            }
            if (kontrol == false)
            {
                kelime.AddLast(bulunan_K);
            }
            return kontrol;
        }

        
        private int Puanla(int hrf_sy)
        {
            int p = 0;
            switch (hrf_sy)
            {
                case 3:
                    p = 3;
                    break;
                case 4:
                    p = 4;
                    break;
                case 5:
                    p = 5;
                    break;
                case 6:
                    p = 7;
                    break;
                case 7:
                    p = 9;
                    break;
                case 8:
                    p = 11;
                    break;
                case 9:
                    p = 15;
                    break;
            }
            lblPuan.Text = (Convert.ToInt32(lblPuan.Text) + p).ToString();

            return p;
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
            tbxKelime.Clear();

        }

        private void Kelime_İşlem_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (cbx_letterJok.SelectedIndex == -1)
            {
                if (3 <= tbxKelime.Text.Length && tbxKelime.Text.Length <= 8)
                {
                    harf_kontrol(gelenHarfler, tbxKelime.Text.ToUpper((new CultureInfo("tr-TR", false))));
                }
                else
                {
                    tbxKelime.Clear();
                    MessageBox.Show("Girdiğiniz kelime harf sayısı jokersiz '3 - 8' arsında olmalıdır kontrol ediniz");
                }
            }
            else
            {
                if (3 <= tbxKelime.Text.Length && tbxKelime.Text.Length <= 9)
                {
                    harf_kontrol(gelenHarfler, tbxKelime.Text.ToUpper((new CultureInfo("tr-TR", false))));
                }
                else
                {
                    tbxKelime.Clear();
                    MessageBox.Show("Girdiğiniz kelime harf sayısı jokerli '3 - 9' arsında olmalıdır kontrol ediniz");
                }
            }

        }

        //tbxlere sadece harf girilmesi için
        private void just_letter(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void tbxKelime_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbx_letterJok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kelime_kontrol(tbxKelime.Text.ToUpper((new CultureInfo("tr-TR", false))), 3);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
