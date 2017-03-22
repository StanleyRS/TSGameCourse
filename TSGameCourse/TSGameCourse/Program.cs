using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSGameCourse
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        /*
         чертаем панел
         чертаем запълнен кръс с фунция за чертаене на елипса
         появява се на произволна точка
         създаваме 2 бутона старт и стоп
         при старт кръга се движи надоло
         при достигане на долна част на панела, отскача обратно с по-ниска скорост */

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
