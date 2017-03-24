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


            //Sincroniza Pesajes (Descarga de ODOO)
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

            //Sincroniza Pesajes (Sube a ODOO)
            //Al subir o actualizar un registro CERRADO, marcar como baja = 1 !!
            basculaDataSetTableAdapters.PESAJESTableAdapter ta = new basculaDataSetTableAdapters.PESAJESTableAdapter();
            basculaDataSet.PESAJESDataTable pesajes_local = ta.GetAll();

            foreach(basculaDataSet.PESAJESRow drPesaje in pesajes_local)
            {
                int id_externo = -1;

                if (!drPesaje.IsID_EXTERNONull())
                {
                    id_externo = Convert.ToInt32(drPesaje["id_externo"]);
                }

                OdooRecord new_pesaje;

                if (id_externo > 0) //Tiene asignado un id_externo
                {
                    //Validamos que realmente existe en Odoo
                    new_pesaje = pesajesModel.Browse(id_externo);
                    if(new_pesaje == null)
                    {
                        //No existe, hay que crearlo
                        new_pesaje = pesajesModel.CreateNew();
                        
                    }
                }
                else
                {
                    new_pesaje = pesajesModel.CreateNew();
                }

                if(new_pesaje.Id <= 0)
                {
                    //Es un registro nuevo en odoo!
                    new_pesaje.SetValue("origin", "DESK");
                    new_pesaje.SetValue("folio", drPesaje["FOLIO"]);
                    new_pesaje.SetValue("vehicle_plate", drPesaje["PLACAS"]);

                    new_pesaje.SetValue("type", "pll"); //Todo: Validar si es de entrada o salida
                    new_pesaje.SetValue("box_weight", drPesaje["PESO_ENTRADA"].ToString()); //Todo: si es entrada es un peso y si es salida es otro
                    new_pesaje.SetValue("vehicle_driver", drPesaje["ID_OPERADOR"]);
                    new_pesaje.SetValue("status", drPesaje["ESTADO"]);

                    var fechaEntrada = Convert.ToDateTime(drPesaje["FECHA_ENTRADA"]).ToString("yyyy-MM-dd HH:mm:ss");

                    new_pesaje.SetValue("date", fechaEntrada);

                    new_pesaje.Save();

                    drPesaje.ID_EXTERNO = new_pesaje.Id;
                    if(drPesaje.ESTADO == "CERRADO")
                    {
                        drPesaje.BAJA = true;
                    }
                    ta.Update(drPesaje);
                }
                else
                {
                    //Ya existe en odoo; que hacer? bajar cambios o subirlos??
                    //Bajan cambios, en escritorio no podran haber cambios mas que el segundo pesaje y la fecha de salida y peso neto


                    //si en odoo es CERRADO y en ESCRITORIO es ABIERTO
                    //Bajar cambios

                    if(drPesaje["ESTADO"].ToString() == "ABIERTO" && new_pesaje.GetStringValue("status") == "CERRADO")
                    {
                        //bajamos los pesos de salida y neto
                        //bajamos el operador y placas
                        //cerramos el registro

                    }

                    
                    //Si en odoo es ABIERTO y en escritorio es CERRADO subir los cambios


                    //Si en odoo y escritorio es ABIERTO bajar cambios 

                    
                    //Si en odoo y escritorio es CERRADO, comprobar valores de peso

                }
                  
                
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

            decimal peso_entrada = 0;

            if (tipo_peso == "pll")
            {
                peso_entrada = record.GetDecimalValue("gross_weight");
            }
            else if(tipo_peso == "psa")
            {
                peso_entrada = record.GetDecimalValue("box_weight");
            }


            basculaDataSetTableAdapters.PESAJESTableAdapter ta = new basculaDataSetTableAdapters.PESAJESTableAdapter();
            Int32 existe = (Int32)ta.ExisteOdoo(id_odoo, folio);

            if(existe == 0)
            {
                Int32 existeFolio = (Int32)ta.ExisteFolio(folio);
                if(existeFolio == 0)
                {

                    //Obtiene nuevo Folio
                    basculaDataSetTableAdapters.FOLIOSTableAdapter taFolios = new basculaDataSetTableAdapters.FOLIOSTableAdapter();
                    int folio_nuevo = (int)taFolios.GetNextFolio("PESAJE");

                    record.SetValue("folio", folio_nuevo);
                    record.Save();

                    taFolios.UpdateFolio(folio_nuevo, "PESAJE");

                    //Viene con ID Negativo
                    var pid = ta.Insert(
                        folio_nuevo, //Folio
                        fecha_entrada,
                        null, //Fecha Salida
                        peso_entrada, //Peso Entrada
                        0, //Peso Salida
                        0, //Peso Neto
                        id_operador, //Operador
                        placas, //PLacas
                        "ABIERTO", //Estado
                        false, //Baja
                        id_odoo, //External ID
                        tipo_peso
                    );

                }
                else
                {
                    //Hay un error de Coherencia en Folios!!!
                    throw new Exception("Error de coherencia en base de datos!!");
                }
            }
            else
            {
                //Si existe y es coherente, actualizarlo
                Int32 id = (Int32)ta.GetId(id_odoo);
                ta.Update(folio, fecha_entrada, null, peso_entrada, 0, 0, id_operador, placas, "ABIERTO", false, id_odoo, tipo_peso, id);
            }
        }
    }
}
