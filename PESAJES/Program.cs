using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PESAJES
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            DialogResult result = (new Login()).ShowDialog();
            if(result == DialogResult.Yes)
            {
                (new FRM_Actualiza()).ShowDialog();
                Application.Run(new FRM_PRINCIPAL());
            }
        }
    }
}
