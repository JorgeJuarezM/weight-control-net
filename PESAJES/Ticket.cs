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

        public Ticket()
        {
            
        }


        public void printEntrada()
        {
            PrinterSettings ps = new PrinterSettings();
            //ps.PrinterName = "Microsoft XPS Document Writer";

            PaperSize pSize = new PaperSize("Custom", 314, 314);
            ps.DefaultPageSettings.PaperSize = pSize;
            PrintDocument docEntrada = new PrintDocument();

            docEntrada.PrinterSettings = ps;
            docEntrada.PrintPage += Doc_PrintPage;
            docEntrada.Print();

        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font fontRegular = new Font("Courier New", 10);
            Font fontRegularBold = new Font("Courier New", 10, FontStyle.Bold);
            Font fontBig = new Font("Courier New", 12);
            Font fontBigBold = new Font("Courier New", 12, FontStyle.Bold);
            

            int offset = 0;


            offset += 20;
            Rectangle rect1 = new Rectangle(10, offset, 294, 40);
            StringFormat f1 = new StringFormat();
            f1.Alignment = StringAlignment.Center;
            e.Graphics.DrawString("RANCHO EL ENRHEDO \r\n S.A. de C.V.", fontBigBold, Brushes.Black, rect1, f1);

            offset += 40;
            rect1 = new Rectangle(10, offset, 294, 40);
            e.Graphics.DrawString("Báscula Pública de 75 Tons.", fontRegularBold, Brushes.Black, rect1, f1);

            offset += 40;
            rect1 = new Rectangle(10, offset, 294, 60);
            e.Graphics.DrawString("CARR. CRUCERO BERNAL-EZEQUIEL MONTES KM. 2 S/N \r\n EZEQUIEL MONTES, QRO.", fontRegular, Brushes.Black, rect1, f1);

            offset += 60;
            rect1 = new Rectangle(10, offset, 294, 40);
            e.Graphics.DrawString("Tel. Cel. 419 191 63 34", fontBig, Brushes.Black, rect1, f1);



            offset += 40;
            e.Graphics.DrawString("Folio No. 68688", fontRegular, Brushes.Black, 20, offset);


            offset += 30;
            e.Graphics.DrawString("ENTRADA".PadLeft(20, '=').PadRight(32, '='), fontRegular, Brushes.Black, 20, offset);


            offset += 20;
            e.Graphics.DrawString("Placas: UKC-5393", fontRegular, Brushes.Black, 20, offset);

            offset += 20;
            e.Graphics.DrawString("Peso Entrada: 14,545.000 kg", fontRegular, Brushes.Black, 20, offset);

            offset += 20;
            e.Graphics.DrawString(DateTime.Now.ToString("H:mm tt  d MMM, yyyy"), fontRegular, Brushes.Black, 20, offset);



        }
    }
}
