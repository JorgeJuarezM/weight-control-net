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
        public string Folio { get; set; }
        public string PesoEntrada { get; set; }
        public string PesoSalida { get; set; }
        public string PesoNeto { get; set; }
        public string FechaEntrada { get; set; }
        public string FechaSalida { get; set; }
        public string Placas { get; set; }

        public string Empresa { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }

        public string Operador { get; set; }
        //public string FolioInt { get; set; }

        int offset = 0;

        public Ticket()
        {
            
        }

        private void loadTicket(int idTicket)
        {
            basculaDataSetTableAdapters.PESAJESTableAdapter p = new basculaDataSetTableAdapters.PESAJESTableAdapter();
            basculaDataSet.PESAJESDataTable tbl = p.GetById(idTicket);

            basculaDataSet.PESAJESRow row  = (basculaDataSet.PESAJESRow)tbl.Rows[0];
            this.Folio = string.Format("{0}/{1}", row.SECUENCIA, row.FOLIO);
            this.PesoEntrada = row.PESO_ENTRADA.ToString();
            this.PesoSalida = row.PESO_SALIDA.ToString();
            this.PesoNeto = Math.Abs(row.PESO_ENTRADA - row.PESO_SALIDA).ToString();

            this.FechaEntrada = row.FECHA_ENTRADA.ToString("h:mm tt  d MM, yyyy");

            if (!row.IsFECHA_SALIDANull())
            {
                this.FechaSalida = row.FECHA_SALIDA.ToString("H:mm tt  d MM, yyyy");
            }

            this.Placas = row.PLACAS;
            
            

            //Datos de Empresa
            basculaDataSetTableAdapters.FOLIOSTableAdapter taFolios = new basculaDataSetTableAdapters.FOLIOSTableAdapter();
            basculaDataSet.FOLIOSDataTable tblFolios = taFolios.GetBySecuencia(row.SECUENCIA);
            basculaDataSet.FOLIOSRow drFolio = (basculaDataSet.FOLIOSRow)tblFolios.Rows[0];
            this.Empresa = drFolio.EMPRESA;
            
            if(!drFolio.IsTELEFONONull())
            {
                this.Telefono = drFolio.TELEFONO;
            }

            this.Domicilio = drFolio.DOMICILIO;


            //Datos Operador
            basculaDataSetTableAdapters.OPERADORESTableAdapter taOperador = new basculaDataSetTableAdapters.OPERADORESTableAdapter();
            basculaDataSet.OPERADORESDataTable tblOperadores = taOperador.GetById(row.ID_OPERADOR);
            basculaDataSet.OPERADORESRow rowOperador = (basculaDataSet.OPERADORESRow)tblOperadores.Rows[0];

            this.Operador = rowOperador.NOMBRE_OPERADOR;


        }


        public void printEntrada(int idTicket)
        {
            this.loadTicket(idTicket);

            PrinterSettings ps = new PrinterSettings();
            PaperSize pSize = new PaperSize("Custom", 314, 314);
            ps.DefaultPageSettings.PaperSize = pSize;
            PrintDocument docEntrada = new PrintDocument();

            docEntrada.PrinterSettings = ps;
            docEntrada.PrintPage += docEntrada_PrintPage;
            docEntrada.Print();

        }

        public void PrintSalida(int ticketId)
        {
            this.loadTicket(ticketId);
            PrinterSettings ps = new PrinterSettings();
            PaperSize pSize = new PaperSize("Custom", 314, 420);
            ps.DefaultPageSettings.PaperSize = pSize;
            PrintDocument docSalida = new PrintDocument();

            docSalida.PrinterSettings = ps;
            docSalida.PrintPage += DocSalida_PrintPage;
            docSalida.Print();
        }

        private void DocSalida_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font fontRegular = new Font("Courier New", 10);
            Font fontRegularBold = new Font("Courier New", 10, FontStyle.Bold);
            Font fontBig = new Font("Courier New", 12);
            Font fontBigBold = new Font("Courier New", 12, FontStyle.Bold);
            

            this.__printEntrada(e);

            offset += 20;
            e.Graphics.DrawString("SALIDA".PadLeft(20, '=').PadRight(32, '='), fontRegular, Brushes.Black, 20, offset);

            offset += 20;
            e.Graphics.DrawString(String.Format("Bruto: {0} kg", this.PesoEntrada), fontRegular, Brushes.Black, 20, offset);

            offset += 20;
            e.Graphics.DrawString(String.Format("Tara: {0} kg", this.PesoSalida), fontRegular, Brushes.Black, 20, offset);

            offset += 20;
            e.Graphics.DrawString(String.Format("Neto: {0} kg", this.PesoNeto), fontRegular, Brushes.Black, 20, offset);

            offset += 20;
            e.Graphics.DrawString(this.FechaSalida, fontRegular, Brushes.Black, 20, offset);

            

        }

        private void docEntrada_PrintPage(object sender, PrintPageEventArgs e)
        {
            this.__printEntrada(e);

        }

        private void __printEntrada(PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font fontRegular = new Font("Courier New", 10);
            Font fontRegularBold = new Font("Courier New", 10, FontStyle.Bold);
            Font fontBig = new Font("Courier New", 12);
            Font fontBigBold = new Font("Courier New", 12, FontStyle.Bold);


            


            offset += 20;
            Rectangle rect1 = new Rectangle(10, offset, 294, 40);
            StringFormat f1 = new StringFormat();
            f1.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(this.Empresa, fontBigBold, Brushes.Black, rect1, f1);


            offset += 40;
            rect1 = new Rectangle(10, offset, 294, 60);
            e.Graphics.DrawString(this.Domicilio, fontRegular, Brushes.Black, rect1, f1);

            offset += 45;
            rect1 = new Rectangle(10, offset, 294, 40);
            e.Graphics.DrawString(String.Format("Teléfono: {0}", this.Telefono), fontBig, Brushes.Black, rect1, f1);


            /***** barcode ***/
            Zen.Barcode.Code128Checksum checksum128 = Zen.Barcode.Code128Checksum.Instance;

            Zen.Barcode.Code128BarcodeDraw drawer = new Zen.Barcode.Code128BarcodeDraw(checksum128);
            Image img = drawer.Draw(this.Folio, 40);

            

            offset += 30;
            e.Graphics.DrawImage(img, 20, offset);
            /***** barcode ***/


            offset += 45;
            e.Graphics.DrawString(string.Format("Folio No. {0}", this.Folio), fontRegular, Brushes.Black, 20, offset);

            offset += 20;
            e.Graphics.DrawString(String.Format("Operador: {0}", this.Operador), fontRegular, Brushes.Black, 20, offset);

            offset += 20;
            e.Graphics.DrawString(String.Format("Placas: {0}", this.Placas), fontRegular, Brushes.Black, 20, offset);


            offset += 30;
            e.Graphics.DrawString("ENTRADA".PadLeft(20, '=').PadRight(32, '='), fontRegular, Brushes.Black, 20, offset);


            offset += 20;
            e.Graphics.DrawString(String.Format("Peso Entrada: {0} kg", this.PesoEntrada), fontRegular, Brushes.Black, 20, offset);

            offset += 20;
            e.Graphics.DrawString(this.FechaEntrada, fontRegular, Brushes.Black, 20, offset);


            

        }
    }
}
