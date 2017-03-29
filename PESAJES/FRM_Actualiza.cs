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
        public event EventHandler<SendMessageEventArgs> SendMessage;

        public FRM_Actualiza()
        {
            InitializeComponent();
        }

        private bool isBackground = false;
        private bool isError = false;

        protected virtual void OnSendMessage(string message, bool isError = false)
        {
            SendMessageEventArgs args = new SendMessageEventArgs() { message = message, isError = isError };
            SendMessage?.Invoke(this, args);
        }

        public void StartUpdate(bool background = false)
        {
            isBackground = background;

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;

            Timer t = new Timer();
            t.Interval = 3000;
            t.Tick += (object sender_timer, EventArgs args) =>
            {
                t.Enabled = false;
                bw.RunWorkerAsync();
            };

            t.Enabled = true;
            t.Start();
        }

        private void FRM_Actualiza_Load(object sender, EventArgs e)
        {
            this.StartUpdate();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            this.RunUpdate();
            try
            {
                isError = false;
                
            }
            catch(Exception ex)
            {
                if(isBackground == false)
                {
                    isError = true;
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    isError = true;
                    OnSendMessage(ex.Message, true);
                }
            }
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(isBackground == false)
            {
                this.close_form();
            }
            else
            {
                if(isError == false)
                {
                    OnSendMessage("!!....Actualizado....!!");
                }
            }
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

        private void RunUpdate()
        {
            //Sincroniza Operadores
            OdooModel operadoresModel = Env.odooApi.GetModel("weight.drivers");
            var operadores = operadoresModel.Search();

            foreach(OdooRecord operador in operadores)
            {
                SyncDriver(operador);
            }

            OdooModel pesajesModel = Env.odooApi.GetModel("weight.order");
            basculaDataSetTableAdapters.PESAJESTableAdapter ta = new basculaDataSetTableAdapters.PESAJESTableAdapter();


            /************************************************/
            /**
             * Obtiene los que estan abiertos en local, actualiza datos que provengan del ERP Odoo,
             * Si en Odoo ya está cerrado, obtiene el peso de salida, cierra el registro en local y lo da de baja
             */
            basculaDataSet.PESAJESDataTable pesajesAbiertos = ta.GetData();
            foreach (basculaDataSet.PESAJESRow drPesaje in pesajesAbiertos)
            {
                int id_externo = -1;

                if (!drPesaje.IsID_EXTERNONull())
                {
                    id_externo = Convert.ToInt32(drPesaje["id_externo"]);
                }

                if(id_externo > 0) //Si tiene asignado un id de odoo
                {
                    OdooRecord pesajeOdoo = pesajesModel.Browse(id_externo);
                    if(pesajeOdoo != null) //Si existe en odoo
                    {
                        //siempre actualiza (Placas, Operador, tipo de pesaje y peso de entrada)
                        drPesaje.PLACAS = pesajeOdoo.GetStringValue("vehicle_plate");
                        drPesaje.ID_OPERADOR = pesajeOdoo.GetIntValue("vehicle_driver");
                        drPesaje.TIPO_PESAJE = pesajeOdoo.GetStringValue("type");

                        if (drPesaje.TIPO_PESAJE == "pll")
                        {
                            drPesaje.PESO_ENTRADA = pesajeOdoo.GetDecimalValue("gross_weight");
                        }
                        else if (drPesaje.TIPO_PESAJE == "psa")
                        {
                            drPesaje.PESO_ENTRADA = pesajeOdoo.GetDecimalValue("box_weight");
                        }


                        if (pesajeOdoo.GetStringValue("status") == "CERRADO")
                        {
                            //Cierra el pesaje en local, y actualiza el segundo peso
                            drPesaje.ESTADO = "CERRADO";
                            drPesaje.FECHA_SALIDA = pesajeOdoo.GetDateTimeValue("out_date").ToLocalTime();

                            if (drPesaje.TIPO_PESAJE == "pll")
                            {
                                drPesaje.PESO_SALIDA = pesajeOdoo.GetDecimalValue("box_weight");
                            }
                            else if (drPesaje.TIPO_PESAJE == "psa")
                            {
                                drPesaje.PESO_SALIDA = pesajeOdoo.GetDecimalValue("gross_weight");
                            }
                            drPesaje.BAJA = true; //Lo Elimina del proceso
                        }

                        ta.Update(drPesaje);
                    }
                }
            }

            /**
             * Obtiene los que están cerrados en local, que no estan dados de baja
             * Si en odoo aun están abiertos, los cierra en odoo y actualiza datos
             * desde local a odoo, peso de salida, peso de entrada
             */

            basculaDataSet.PESAJESDataTable pesajesCerrados = ta.GetCerrados();
            foreach (basculaDataSet.PESAJESRow drPesaje in pesajesCerrados)
            {
                int id_externo = -1;

                if (!drPesaje.IsID_EXTERNONull())
                {
                    id_externo = Convert.ToInt32(drPesaje["id_externo"]);
                }

                if(id_externo > 0) //Contiene un id_externo de odoo
                {
                    OdooRecord pesajeOdoo = pesajesModel.Browse(id_externo);
                    if(pesajeOdoo != null) //Si existe en odoo
                    {
                        if(pesajeOdoo.GetStringValue("status") == "ABIERTO")
                        {
                            pesajeOdoo.SetValue("status", "CERRADO");
                            pesajeOdoo.SetValue("out_date", drPesaje.FECHA_SALIDA.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));
                            if (drPesaje.TIPO_PESAJE == "pll")
                            {
                                pesajeOdoo.SetValue("gross_weight", drPesaje.PESO_ENTRADA.ToString());
                                pesajeOdoo.SetValue("box_weight", drPesaje.PESO_SALIDA.ToString());
                            }
                            else if (drPesaje.TIPO_PESAJE == "psa")
                            {
                                pesajeOdoo.SetValue("gross_weight", drPesaje.PESO_SALIDA.ToString());
                                pesajeOdoo.SetValue("box_weight", drPesaje.PESO_ENTRADA.ToString());
                            }
                            drPesaje.BAJA = true;

                            pesajeOdoo.Save();
                            ta.Update(drPesaje);
                        }
                    }
                }
            }



            /**
             * Obtener de odoo todos los abiertos que se capturaron en linea
             * Si no existen en local, los damos de alta
             */

            var pesajes = pesajesModel.Search(new object[]
            {
                new object[] {"status", "=", "ABIERTO"},
                new object[] {"origin", "=", "ODOO"}
            });

            foreach(OdooRecord pesajeOdoo in pesajes)
            {
                int idOdoo = pesajeOdoo.GetIntValue("id");
                int folio = pesajeOdoo.GetIntValue("folio");

                int existe = (int)ta.ExisteOdoo(idOdoo, folio);
                if(existe == 0) //No existe en local
                {
                    decimal pesajeEntrada = 0;
                    decimal pesajeSalida = 0;
                    DateTime? fechaSalida = null;
                    bool baja = false;

                    if (pesajeOdoo.GetStringValue("type") == "pll")
                    {
                        pesajeEntrada = pesajeOdoo.GetDecimalValue("gross_weight");
                        pesajeSalida = pesajeOdoo.GetDecimalValue("box_weight");
                    }
                    else if (pesajeOdoo.GetStringValue("type") == "psa")
                    {
                        pesajeEntrada = pesajeOdoo.GetDecimalValue("box_weight");
                        pesajeSalida = pesajeOdoo.GetDecimalValue("gross_weight");
                    }

                    if(pesajeOdoo.GetStringValue("status") == "CERRADO")
                    {
                        fechaSalida = pesajeOdoo.GetDateTimeValue("out_date");
                        baja = true;
                    }


                    ta.Insert(
                            pesajeOdoo.GetIntValue("folio"),
                            pesajeOdoo.GetDateTimeValue("date"),
                            fechaSalida,
                            pesajeEntrada,
                            pesajeSalida,
                            Math.Abs(pesajeEntrada - pesajeSalida),
                            pesajeOdoo.GetIntValue("vehicle_driver"),
                            pesajeOdoo.GetStringValue("vehicle_plate"),
                            pesajeOdoo.GetStringValue("status"),
                            baja,
                            idOdoo,
                            pesajeOdoo.GetStringValue("type")
                            );
                }
            }



            /**
             * Obtenemos de local todos los que baja = false, (cerrados y abiertos) si no existen en odoo, los damos de alta
             */

            basculaDataSet.PESAJESDataTable pesajesTodos = ta.GetAll();
            foreach (basculaDataSet.PESAJESRow drPesaje in pesajesTodos)
            {
                int id_externo = -1;
                if (!drPesaje.IsID_EXTERNONull())
                {
                    id_externo = Convert.ToInt32(drPesaje["id_externo"]);
                }

                if(id_externo <= 0) //No existe en Odoo
                {
                    OdooRecord pesajeOdoo = pesajesModel.CreateNew();

                    pesajeOdoo.SetValue("origin", "DESK");
                    pesajeOdoo.SetValue("folio", drPesaje.FOLIO);
                    pesajeOdoo.SetValue("vehicle_plate", drPesaje.PLACAS);

                    pesajeOdoo.SetValue("type", drPesaje.TIPO_PESAJE); //Todo: Validar si es de entrada o salida

                    if (drPesaje.TIPO_PESAJE == "pll")
                    {
                        pesajeOdoo.SetValue("gross_weight", drPesaje.PESO_ENTRADA.ToString());
                        pesajeOdoo.SetValue("box_weight", drPesaje.PESO_SALIDA.ToString());
                    }
                    else if (drPesaje.TIPO_PESAJE == "psa")
                    {
                        pesajeOdoo.SetValue("gross_weight", drPesaje.PESO_SALIDA.ToString());
                        pesajeOdoo.SetValue("box_weight", drPesaje.PESO_ENTRADA.ToString());
                    }


                    pesajeOdoo.SetValue("vehicle_driver", drPesaje.ID_OPERADOR);
                    pesajeOdoo.SetValue("status", drPesaje.ESTADO);

                    var fechaEntrada = drPesaje.FECHA_ENTRADA.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");

                    pesajeOdoo.SetValue("date", fechaEntrada);

                   

                    
                    if(drPesaje.ESTADO == "CERRADO")
                    {
                        drPesaje.BAJA = true;
                        pesajeOdoo.SetValue("out_date", drPesaje.FECHA_SALIDA.ToUniversalTime().ToString("yyyy-MM-dd"));
                    }


                    pesajeOdoo.Save();
                    drPesaje.ID_EXTERNO = pesajeOdoo.Id;
                    ta.Update(drPesaje);
                }
            }


            /************************************************/


            //Sincroniza Pesajes (Sube a ODOO)
            //Al subir o actualizar un registro CERRADO, marcar como baja = 1 !!
            /*

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

                    new_pesaje.SetValue("type", drPesaje.TIPO_PESAJE); //Todo: Validar si es de entrada o salida

                    if(drPesaje.TIPO_PESAJE == "pll")
                    {
                        new_pesaje.SetValue("gross_weight", drPesaje["PESO_ENTRADA"].ToString());
                        new_pesaje.SetValue("box_weight", drPesaje["PESO_SALIDA"].ToString()); 
                    }
                    else if(drPesaje.TIPO_PESAJE == "psa")
                    {
                        new_pesaje.SetValue("gross_weight", drPesaje["PESO_SALIDA"].ToString());
                        new_pesaje.SetValue("box_weight", drPesaje["PESO_ENTRADA"].ToString());
                    }

                   
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


                    //Siempre se bajan los cambios de operador, placas y tipo de pesaje
                    drPesaje.ID_OPERADOR = new_pesaje.GetIntValue("vehicle_driver");
                    drPesaje.PLACAS = new_pesaje.GetStringValue("vehicle_plate");


                    //si en odoo es CERRADO y en ESCRITORIO es ABIERTO
                    //Bajar cambios

                    if (drPesaje["ESTADO"].ToString() == "ABIERTO" && new_pesaje.GetStringValue("status") == "CERRADO")
                    {
                        //bajamos los pesos
                        drPesaje.ESTADO = "CERRADO";
                        drPesaje.TIPO_PESAJE = new_pesaje.GetStringValue("type");
                        drPesaje.FECHA_SALIDA = new_pesaje.GetDateTimeValue("out_date");
                        this.baja_pesos(drPesaje, new_pesaje);
                    }


                    //Si en odoo es ABIERTO y en escritorio es CERRADO subir los cambios
                    if (drPesaje["ESTADO"].ToString() == "CERRADO" && new_pesaje.GetStringValue("status") == "ABIERTO")
                    {
                        //Subimos los pesos
                        new_pesaje.SetValue("type", drPesaje.TIPO_PESAJE);
                        new_pesaje.SetValue("status", "CERRADO");
                        new_pesaje.SetValue("out_date", drPesaje.FECHA_SALIDA.ToString("yyyy-MM-dd HH:mm:ss"));
                        this.subir_pesos(drPesaje, new_pesaje);
                    }

                    //Si en odoo y escritorio es ABIERTO bajar cambios 
                    if (drPesaje["ESTADO"].ToString() == "ABIERTO" && new_pesaje.GetStringValue("status") == "ABIERTO")
                    {
                        //bajamos todos los pesos
                        drPesaje.TIPO_PESAJE = new_pesaje.GetStringValue("type");
                        this.baja_pesos(drPesaje, new_pesaje);
                    }

                    //Si en odoo y escritorio es CERRADO, comprobar valores de peso
                    if(drPesaje.ESTADO == "CERRADO" && new_pesaje.GetStringValue("status") == "CERRADO")
                    {
                        drPesaje.BAJA = true;
                    }

                    new_pesaje.Save();
                    ta.Update(drPesaje);
                }
            }
            */

            //Sincroniza Pesajes (Descarga de ODOO)
            //var pesajes = pesajesModel.Search(new object[]
            //{
            //    new object[] {"status", "=", "ABIERTO"},
            //    new object[] {"origin", "=", "ODOO"}
            //});


            //foreach (OdooRecord pesaje in pesajes)
            //{
            //    SyncRecord_DOWN(pesaje);
            //}
        }

        private void subir_pesos(basculaDataSet.PESAJESRow drPesaje, OdooRecord new_pesaje)
        {
            if (drPesaje.TIPO_PESAJE == "pll")
            {
                //llegada, peso 1 = lleno, peso 2 = vacio
                new_pesaje.SetValue("gross_weight", drPesaje.PESO_ENTRADA.ToString());
                new_pesaje.SetValue("box_weight", drPesaje.PESO_SALIDA.ToString());
            }
            else if (drPesaje.TIPO_PESAJE == "psa")
            {
                //llegada, peso 1 = vacio, peso 2 = lleno
                new_pesaje.SetValue("gross_weight", drPesaje.PESO_SALIDA.ToString());
                new_pesaje.SetValue("box_weight", drPesaje.PESO_ENTRADA.ToString());
            }
        }

        private void baja_pesos(basculaDataSet.PESAJESRow drPesaje, OdooRecord new_pesaje)
        {
            if (drPesaje.TIPO_PESAJE == "pll")
            {
                //llegada, peso 1 = lleno, peso 2 = vacio
                drPesaje.PESO_ENTRADA = new_pesaje.GetDecimalValue("gross_weight");
                drPesaje.PESO_SALIDA = new_pesaje.GetDecimalValue("box_weight");
                drPesaje.PESO_NETO = Math.Abs(drPesaje.PESO_ENTRADA - drPesaje.PESO_SALIDA);
            }
            else if (drPesaje.TIPO_PESAJE == "psa")
            {
                //llegada, peso 1 = vacio, peso 2 = lleno
                drPesaje.PESO_ENTRADA = new_pesaje.GetDecimalValue("box_weight");
                drPesaje.PESO_SALIDA = new_pesaje.GetDecimalValue("gross_weight");
                drPesaje.PESO_NETO = Math.Abs(drPesaje.PESO_ENTRADA - drPesaje.PESO_SALIDA);
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

    public class SendMessageEventArgs : EventArgs
    {
        public string message { get; set; }
        public bool isError { get; set; } = false;
    }
}
