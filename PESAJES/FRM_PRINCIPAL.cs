using System;
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
            serialPort1.Open();

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
                Frm_PreguntaActualiza f = new Frm_PreguntaActualiza();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.loadData();
                }
                

            };

            t.Enabled = true;
            t.Start();

        }

        private void loadData()
        {
            this.basculaDataSet.Clear();
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
                pESAJESBindingSource.CancelEdit();

                e.Handled = true;

                int position = pESAJESBindingSource.Find("FOLIO", value);
                if(position >= 0)
                {
                    pESAJESBindingSource.Position = position;
                }
                else
                {
                    MessageBox.Show("Registro no encontrado");
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            try
            {
                
                if (this.pESAJESBindingSource.Current != null)
                {
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

                        basculaDataSetTableAdapters.FOLIOSTableAdapter tFolios = new basculaDataSetTableAdapters.FOLIOSTableAdapter();
                        int folio_nuevo = (int)tFolios.GetNextFolio("PESAJE");
                        tFolios.UpdateFolio(folio_nuevo, "PESAJE");

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


                    if(dr.ESTADO == "CERRADO")
                    {
                        //Imprime Ticket
                        Ticket t = new Ticket();
                        t.print();
                    }
                    
                }


                this.pESAJESTableAdapter.Fill(this.basculaDataSet.PESAJES);
                btnCancelar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            serialPort1.Open();
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
            decimal toSend = Convert.ToDecimal(data);
            setWeight(toSend);
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
    }
}
