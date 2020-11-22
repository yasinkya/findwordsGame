using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Management.Instrumentation;
using System.ComponentModel;

namespace Yazılım_Yapımı_Ödev
{
    class kelimeAra
    {
        private string bulunan = "";
        private LinkedList<char> LListHarf = new LinkedList<char>();

        public kelimeAra(string harfler) //bu constructorda gelen harfler bir linkedliste atıldı
        {
            this.LListHarf.AddFirst(harfler[0]);
            for (int i = 1; i < harfler.Length; i++)
            {
                this.LListHarf.AddLast(harfler[i]);
            }
        }

        public string ara()
        {
            string retStr = "";

            string fileLoc = @"C:\Users\Kaya\Desktop\projects\cs_p\Kelime Bulma c# - proje dizini\words\all.txt";
            FileStream fs = new FileStream(fileLoc, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string[] kelimeler = satiroku(sw.ReadLine());   //kelimelerin olduğu dosya açıldı ve okunan satır düzenlenip diziye aktarıldı

            while (true)
            {
                harfKontrol(kelimeler, this.LListHarf); //satırdaki kelimeler gelen harflerle kıyaslama yapılı
                if (bulunan == "") //o satırdaki kelimeler harflerle uyuşmadı ise
                {
                    if ((kelimeler = satiroku(sw.ReadLine())) != null) //bir sonraki satır null olana kadar döngü devam eder
                    {
                        continue;
                    }
                    else //tüm satırlar okundu ama kelime bulunamadı
                    {
                        retStr = null;
                        break;
                    }
                }
                else //o satırda uygun kelime bulundu 
                {
                    retStr = this.bulunan;
                    break;
                }
            }

            return retStr;
        }

        private string[] satiroku(string streamR) //kelime verilerinin bulunduğu dosyadan satırlar okunup düzenleme yapılır
        {
            if (streamR != null)
            {
                char[] toTrim = { ',', ' ' };
                string[] ayriKelimeler = streamR.Split();
                string[] duzen = new string[ayriKelimeler.Length];

                for (int i = 0; i < ayriKelimeler.Length; i++)
                {
                    duzen[i] = ayriKelimeler[i].TrimEnd(toTrim).ToUpper(new CultureInfo("tr-TR", false));
                }

                return duzen;
            }
            return null;
        }

        private void harfKontrol(string[] kelimeler, LinkedList<char> LListharf)
        {
            bool bulundu = false;
            int index = 0, last = kelimeler.Length;

            foreach (string kelime in kelimeler)
            {
                LinkedList<char> tempLlist = new LinkedList<char>(LListHarf);
                int kontrol = 1;

                for (int i = 0; i < kelime.Length; i++) //kelimenin harfleri sırayla
                {
                    for (int j = 0; j < tempLlist.Count; j++)  //tmeplistte var mı kontrol edilir
                    {
                        if (kelime[i] == tempLlist.ElementAt(j))
                        {
                            if (i == kelime.Length - 1) //kelimenin tüm harfleri kontrol edildi ve hepsi bulundu ise 
                            {                               //0 parametresi ile döngü tamamen sonlandırılacak
                                kontrol = 0;
                            }
                            tempLlist.Remove(tempLlist.ElementAt(j));
                            break;
                        }
                        else if (kelime[i] != tempLlist.ElementAt(j) && j == tempLlist.Count - 1) // kelimedeki i. harf templistte bulunamadı ise 
                        {                                                                               //-1 parametresi ile döngü tamamen sonlanacak
                            kontrol = -1;
                            break;
                        }
                    }

                    if (kontrol == 1) //kelimenin ilk harfi bulundu sıradaki harfe geç
                    {
                        continue;
                    }
                    else if (kontrol == 0)//kelimedeki tüm hafler bulundu
                    {
                        bulundu = true;
                        break;
                    }
                    else if (kontrol == -1) //kelimede harf bulunamadı
                    {
                        bulundu = false;
                        break;
                    }
                }

                index++;    //anlık olarak dizinin kaçıncı indexinde olduğunu tutar
                if (bulundu == true)
                {
                    this.bulunan = kelime;
                    break;
                }
                else if (bulundu == false && index != last) //dizinin son indexine kadar döngü devam eder
                {
                    continue;
                }
                else if (bulundu == false && index == last)
                {
                    break;
                }

            }

        }


    }
}
