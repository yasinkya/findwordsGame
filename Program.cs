using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Yapımı_Ödev
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  //program.cs sınıfından hangi kısım çalıştırılmak istenirse
        {                   // diğer kısım yorum satırına alınmalı

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new form2());
            Application.Run(new Kelime_İşlem());
        }
    }
}
