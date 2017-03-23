using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;

namespace PESAJES
{
    class Ticket
    {
        PrintDocument doc;

        public Ticket()
        {
            doc = new PrintDocument();
        }


        public void print()
        {
            PrinterSettings ps = new PrinterSettings();
            ps.PrinterName = "Microsoft XPS Document Writer";

            PaperSize pSize = new PaperSize("Custom", 314, 314);
            ps.DefaultPageSettings.PaperSize = pSize;


            doc.PrinterSettings = ps;


            doc.PrintPage += Doc_PrintPage;

            doc.Print();

        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);


            graphics.DrawString("Hola Mundo", font, Brushes.Black, 0, 0);



        }
    }
}
