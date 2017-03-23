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
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.close_form();
        }

        private void close_form()
        {
            if(InvokeRequired)
            {
                this.Invoke(new Action(()=> close_form()));
            }
            else
            {
                this.Close();
            }
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


            foreach (OdooRecord pesaje in pesajes)
            {
                SyncRecord_DOWN(pesaje);
            }

        }

        private void SyncDriver(OdooRecord record)
        {
            Int32 id_odoo = record.GetIntValue("id");
            basculaDataSetTableAdapters.OPERADORESTableAdapter ta = new basculaDataSetTableAdapters.OPERADORESTableAdapter();

            Int32 existeOdoo = (Int32)ta.ExisteOdoo(id_odoo);

            string nombre_operador = record.GetStringValue("name");
            string placas = record.GetStringValue("vehicle_plate");
            string telefono = record.GetStringValue("phone_number");

            if (existeOdoo == 0)
            {
                ta.Insert(nombre_operador, placas, telefono, id_odoo);
            }
            else if(existeOdoo == 1)
            {
                //Update
                Int32 id = (Int32)ta.GetId(id_odoo);
                ta.Update(nombre_operador, placas, telefono, id_odoo, id);
            }

        }

        private void SyncRecord_DOWN(OdooRecord record)
        {
            basculaDataSetTableAdapters.OPERADORESTableAdapter taOperador = new basculaDataSetTableAdapters.OPERADORESTableAdapter();

            Int32 id_odoo = record.GetIntValue("id");
            Int32 folio = record.GetIntValue("folio");

            Int32 id_operador_odoo = record.GetIntValue("vehicle_driver");
            Int32 id_operador = (Int32)taOperador.GetId(id_operador_odoo);
            DateTime fecha_entrada = record.GetDateTimeValue("date");
            
            string placas = record.GetStringValue("vehicle_plate");

            string tipo_peso = record.GetStringValue("type");

            decimal peso_salida = 0;

            if (tipo_peso == "pll")
            {
                peso_salida = record.GetDecimalValue("gross_weight");
            }
            else if(tipo_peso == "psa")
            {
                peso_salida = record.GetDecimalValue("box_weight");
            }


            basculaDataSetTableAdapters.PESAJESTableAdapter ta = new basculaDataSetTableAdapters.PESAJESTableAdapter();
            Int32 existe = (Int32)ta.ExisteOdoo(id_odoo, folio);

            if(existe == 0)
            {
                Int32 existeFolio = (Int32)ta.ExisteFolio(folio);
                if(existeFolio == 0)
                {
                    ta.Insert(
                        folio, //Folio
                        fecha_entrada,
                        null, //Fecha Salida
                        0, //Peso Entrada
                        peso_salida, //Peso Salida
                        0, //Peso Neto
                        id_operador, //Operador
                        placas, //PLacas
                        "ABIERTO", //Estado
                        false, //Baja
                        id_odoo //External ID
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
                Int32 id = (Int32)ta.GetId(id_odoo);
                ta.Update(folio, fecha_entrada, null, 0, peso_salida, 0, id_operador, placas, "ABIERTO", false, id_odoo, id);
            }
        }
    }
}
