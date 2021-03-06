﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PESAJES
{
    public partial class FRM_PRINCIPAL : Form
    {
        public FRM_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void tRANSPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //(new FRM_TRANSPORTES()).ShowDialog();
        }

        private void oPERADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FRM_OPERADORES()).ShowDialog();
        }

        private void pESAJESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
                                  
            
        }

        private void FRM_PRINCIPAL_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basculaDataSet.FOLIOS' Puede moverla o quitarla según sea necesario.
            this.fOLIOSTableAdapter.Fill(this.basculaDataSet.FOLIOS);
            fOLIOTextBox.Select();
            fOLIOTextBox.Focus();
            fOLIOTextBox.SelectAll();

            try
            {
                serialPort1.PortName = Properties.Settings.Default.PuertoCOM;
                serialPort1.Open();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al abrir puerto de comunicación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DataTable tblTipos = new DataTable();
            tblTipos.Columns.Add("Key");
            tblTipos.Columns.Add("Value");

            DataRow dr1 = tblTipos.NewRow();
            dr1["Key"] = "pll";
            dr1["Value"] = "Pesaje de Llegada";

            tblTipos.Rows.Add(dr1);

            DataRow dr2 = tblTipos.NewRow();
            dr2["Key"] = "psa";
            dr2["Value"] = "Pesaje de Salida";

            tblTipos.Rows.Add(dr2);

            txtTipo.DataSource = tblTipos;
            txtTipo.DisplayMember = "Value";
            txtTipo.ValueMember = "Key";

            this.loadData();

            //Background Update

            Timer t = new Timer();
            t.Interval = 300000;
            t.Tick += (object sender_timer, EventArgs args) =>
            {
                try
                {
                    Frm_PreguntaActualiza f = new Frm_PreguntaActualiza();
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        this.loadData();
                    }
                }
                catch (Exception) { }
            };

            t.Enabled = true;
            t.Start();

        }

        private void loadData()
        {
            this.basculaDataSet.Clear();

            this.fOLIOSTableAdapter.Fill(this.basculaDataSet.FOLIOS);

            // TODO: esta línea de código carga datos en la tabla 'basculaDataSet.OPERADORES' Puede moverla o quitarla según sea necesario.
            this.oPERADORESTableAdapter.Fill(this.basculaDataSet.OPERADORES);
            // TODO: esta línea de código carga datos en la tabla 'basculaDataSet.PESAJES' Puede moverla o quitarla según sea necesario.
            this.pESAJESTableAdapter.Fill(this.basculaDataSet.PESAJES);
           
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            fOLIOTextBox.Enabled = false;
            pESO_SALIDATextBox.ReadOnly = false;
            iD_OPERADORComboBox.Enabled = true;
            pLACASTextBox.ReadOnly = false;
            txtTipo.Enabled = true;
            btnRegistrar.Enabled = true;
            txtEmpresa.Enabled = true;


            this.pESAJESBindingSource.AddNew();

            //this.basculaDataSet.PESAJES.AddPESAJESRow(-1, DateTime.Now, null, 0, 0, 0,
            //    null, null, "__NUEVO__", false, "");

            //pESAJESBindingSource.MoveLast();

            if (this.pESAJESBindingSource.Current != null)
            {
                basculaDataSet.PESAJESRow dr = (basculaDataSet.PESAJESRow)((DataRowView)this.pESAJESBindingSource.Current).Row;
                dr.ESTADO = "NUEVO";
                dr.FOLIO = -1;
                dr.FECHA_ENTRADA = DateTime.Now;
                dr.PESO_ENTRADA = 0;
                dr.PESO_SALIDA = 0;
                dr.PESO_NETO = 0;
                dr.BAJA = false;
                //dr.PLACAS = "-";
                this.pESAJESBindingSource.ResetCurrentItem();
            }

            btnCancelar.Enabled = true;
        }

        private void pESO_SALIDATextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //Admite solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pESO_SALIDATextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.pESAJESBindingSource.Current != null)
            {
                basculaDataSet.PESAJESRow dr = (basculaDataSet.PESAJESRow)((DataRowView)this.pESAJESBindingSource.Current).Row;
                if(dr.ESTADO == "NUEVO" || dr.ESTADO == "ABIERTO")
                {
                    decimal entrada = 0;
                    decimal.TryParse(pESO_SALIDATextBox.Text, out entrada);

                    decimal tara = 0;
                    decimal.TryParse(pESO_ENTRADATextBox.Text, out tara);

                    decimal neto = entrada - tara;
                    neto = Math.Abs(neto);

                    pESO_NETOTextBox.Text = neto.ToString("0.000");
                }
            }


        }

        private void pESAJESBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if(pESAJESBindingSource.Current != null)
            {
                try
                {
                    basculaDataSet.PESAJESRow dr = (basculaDataSet.PESAJESRow)((DataRowView)pESAJESBindingSource.Current).Row;
                    fOLIOTextBox.Text = String.Format("{0}/{1}", dr.SECUENCIA, dr.FOLIO);
                }
                catch (Exception) { }
            }
        }

        private void iD_OPERADORComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var id_operador_obj = iD_OPERADORComboBox.SelectedValue;
                int id_operador = Convert.ToInt32(id_operador_obj);

                oPERADORESBindingSource.Position = oPERADORESBindingSource.Find("id", id_operador);
                if (oPERADORESBindingSource.Current != null)
                {
                    basculaDataSet.OPERADORESRow drOperador = (basculaDataSet.OPERADORESRow)((DataRowView)oPERADORESBindingSource.Current).Row;
                    //iD_TRANSPORTEComboBox.SelectedValue = drOperador.ID_TRANSPORTE;
                    pLACASTextBox.Text = drOperador.PLACAS;
                }
            }
            catch (Exception) { }
        }

        private void fOLIOTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string value = fOLIOTextBox.Text;
                string[] valueSplit = value.Split('/');

                string folio = "";
                string serie = "";

                if(valueSplit.Length >= 2)
                {
                    serie = valueSplit[0];
                    folio = valueSplit[1];
                }
                else
                {
                    valueSplit = value.Split('-');
                    if(valueSplit.Length >= 2)
                    {
                        serie = valueSplit[0];
                        folio = valueSplit[1];
                    }
                }


                pESAJESBindingSource.CancelEdit();

                e.Handled = true;


                var pesajes = from p in this.basculaDataSet.PESAJES
                              where p.SECUENCIA == serie && p.FOLIO.ToString() == folio
                              select p.ID;


                int position = -1;

                foreach(var p in pesajes)
                {
                    position = pESAJESBindingSource.Find("ID", p);
                }


                if(position >= 0)
                {
                    pESAJESBindingSource.Position = position;
                    
                }
                else
                {
                    MessageBox.Show("Registro no encontrado");
                }

                fOLIOTextBox.Focus();
                fOLIOTextBox.SelectAll();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //serialPort1.Close();
            try
            {
               
                if (this.pESAJESBindingSource.Current != null)
                {

                    if(iD_OPERADORComboBox.SelectedValue == null)
                    {
                        //registrar operador
                        if(iD_OPERADORComboBox.Text.Length > 0)
                        {
                            int operador = (int)this.oPERADORESTableAdapter.InsertQuery(iD_OPERADORComboBox.Text, pLACASTextBox.Text, null, null);
                            
                            this.oPERADORESTableAdapter.Fill(basculaDataSet.OPERADORES);
                            iD_OPERADORComboBox.SelectedValue = operador;

                        } else
                        {
                            throw new Exception("Indique el nombre del operador");
                        }
                        
                    }


                    //this.Validate();
                    this.pESAJESBindingSource.EndEdit();

                    basculaDataSet.PESAJESRow dr = (basculaDataSet.PESAJESRow)((DataRowView)this.pESAJESBindingSource.Current).Row;

                    if (dr.IsID_OPERADORNull())
                    {
                        throw new Exception("Selecciona un Operador Valido");
                    }


                    //dr.PLACAS = iD_TRANSPORTEComboBox.Text;

                    if (dr.ESTADO == "NUEVO")
                    {
                        string secuencia = txtEmpresa.SelectedValue.ToString();
                        basculaDataSetTableAdapters.FOLIOSTableAdapter tFolios = new basculaDataSetTableAdapters.FOLIOSTableAdapter();
                        int folio_nuevo = (int)tFolios.GetNextFolio(secuencia);
                        tFolios.UpdateFolio(folio_nuevo, secuencia);

                        //dr.SECUENCIA = secuencia;
                        dr.FECHA_ENTRADA = DateTime.Now;
                        dr.BAJA = false;

                        dr.ESTADO = "ABIERTO";
                        dr.PESO_ENTRADA = dr.PESO_SALIDA;
                        dr.PESO_SALIDA = 0;
                        dr.PESO_NETO = 0;
                        dr.FOLIO = folio_nuevo;

                    }
                    else if (dr.ESTADO == "ABIERTO")
                    {
                        basculaDataSet.PESAJESRow drU = (basculaDataSet.PESAJESRow)((DataRowView)this.pESAJESBindingSource.Current).Row;
                        drU.PESO_NETO = drU.PESO_SALIDA - drU.PESO_ENTRADA;
                        drU.FECHA_SALIDA = DateTime.Now;

                        if(MessageBox.Show("Deseas cerrar el Pesaje?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            drU.ESTADO = "CERRADO";
                            drU.FECHA_SALIDA = DateTime.Now;
                        }
                    }


                    this.tableAdapterManager.UpdateAll(this.basculaDataSet);

                    iD_OPERADORComboBox.Enabled = false;
                    //iD_TRANSPORTEComboBox.Enabled = false;
                    fOLIOTextBox.Enabled = true;
                    txtTipo.Enabled = false;
                    pLACASTextBox.ReadOnly = true;
                    txtEmpresa.Enabled = false;


                    if (dr.ESTADO == "CERRADO")
                    {
                        //Imprime Ticket
                        Ticket t = new Ticket();
                        t.PrintSalida(dr.ID);
                        
                    }
                    else if(dr.ESTADO == "ABIERTO")
                    {
                        Ticket t = new Ticket();
                        t.printEntrada(dr.ID);
                    }
                    
                }


                this.pESAJESTableAdapter.Fill(this.basculaDataSet.PESAJES);
                btnCancelar.Enabled = false;

                fOLIOTextBox.Focus();
                fOLIOTextBox.SelectAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {
                (new FRM_Actualiza()).ShowDialog();
            }
            catch (Exception) { };

            //serialPort1.Open();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            pESAJESBindingSource.CancelEdit();

            btnCancelar.Enabled = false;


        }

        private void pESAJESBindingNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            pESAJESBindingSource.CancelEdit();
        }

        private void sincronizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FRM_Actualiza()).ShowDialog();
            loadData();
        }

        private void pESAJESBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            string data = port.ReadLine();
            try
            {
                decimal toSend = Convert.ToDecimal(data);
                setWeight(toSend);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void setWeight(decimal data)
        {
            if(InvokeRequired)
            {
                this.Invoke(new Action(() => { setWeight(data); }));
            }
            else
            {
                pESO_SALIDATextBox.Text = data.ToString("0.000");
            }
            
        }

        private void fOLIOTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
