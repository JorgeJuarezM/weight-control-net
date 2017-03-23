using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PESAJES.odoo;

namespace PESAJES
{
    public partial class FRM_Actualiza : Form
    {
        public FRM_Actualiza()
        {
            InitializeComponent();
        }

        private void FRM_Actualiza_Load(object sender, EventArgs e)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerAsync();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            OdooModel pesajesModel = Env.odooApi.GetModel("weight.order");
            var pesajes = pesajesModel.Search(new object[]
            {
                new object[] {"status", "=", "ABIERTO"},
                new object[] {"origin", "=", "ODOO"}
            });


            foreach(OdooRecord pesaje in pesajes)
            {
                SyncRecord(pesaje);
            }

        }

        private void SyncRecord(OdooRecord record)
        {
            Int32 folio = record.GetIntValue("folio");
            basculaDataSetTableAdapters.PESAJESTableAdapter ta = new basculaDataSetTableAdapters.PESAJESTableAdapter();
            Int32 existe = (Int32)ta.ExisteFolio(folio);

            if(existe == 0)
            {
                ta.Insert(
                        folio,
                        record.GetDateTimeValue("date"),
                        null,
                        0,
                        record.GetDecimalValue("gross_weight"),
                        0,
                        1,
                        1,
                        "ABIERTO",
                        false,
                        record.GetStringValue("vehicle_plate")
                    );
            }


        }
    }
}
