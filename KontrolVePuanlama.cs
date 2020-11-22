using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Yapımı_Ödev
{
    class KontrolVePuanlama
    {
        private int puan ;
        private string BulunanKelime = "";
        private ListBox lbxB;
        
        public KontrolVePuanlama(ListBox lbxB, string BulunanKelime)
        {
            this.BulunanKelime = BulunanKelime;
            this.lbxB = lbxB;
        }

        
        public int Puanla()
        {
            int p = 0;

            if (kontrol() == false) //konrol fonsiyonunda kelime daha önce kullanılmış mı kontrol ettikten sonra puan verilir
            {
                switch (this.BulunanKelime.Length)
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
            }
            
            return p;
        }

        private bool kontrol()
        {
            bool retB = false;

            for (int i = 0; i < lbxB.Items.Count; i++)
            {
                string temp = lbxB.Items[i].ToString().Substring(0, this.BulunanKelime.Length); //listboxa kelimeler puanlarıyla yazıldığından gereksiz kısım atılır
                if (this.BulunanKelime == temp)
                {
                    return true;
                }
                else
                    retB = false;
            }
            return retB;

        }

    }
}
