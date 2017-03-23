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
            //Sincroniza Operadores
            OdooModel operadoresModel = Env.odooApi.GetModel("weight.drivers");
            var operadores = operadoresModel.Search();

            foreach(OdooRecord operador in operadores)
            {
                SyncDriver(operador);
            }



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

        private void SyncDriver(OdooRecord record)
        {

        }

        private void SyncRecord(OdooRecord record)
        {
            Int32 id_odoo = record.GetIntValue("id");
            Int32 folio = record.GetIntValue("folio");


            basculaDataSetTableAdapters.PESAJESTableAdapter ta = new basculaDataSetTableAdapters.PESAJESTableAdapter();
            Int32 existe = (Int32)ta.ExisteOdoo(id_odoo, folio);

            if(existe == 0)
            {
                Int32 existeFolio = (Int32)ta.ExisteFolio(folio);
                if(existeFolio == 0)
                {
                    ta.Insert(
                        record.GetIntValue("folio"), //Folio
                        record.GetDateTimeValue("date"),
                        null, //Fecha Salida
                        0, //Peso Entrada
                        record.GetDecimalValue("gross_weight"), //Peso Salida
                        0, //Peso Neto
                        1, //Operador
                        record.GetStringValue("vehicle_plate"), //PLacas
                        "ABIERTO", //Estado
                        false, //Baja
                        record.GetIntValue("id") //External ID
                    );
                }
                else
                {
                    //Hay un error de Coherencia en Folios!!!
                }
            }
            else
            {
                //Si existe y es coherente, actualizarlo
            }
        }
    }
}
