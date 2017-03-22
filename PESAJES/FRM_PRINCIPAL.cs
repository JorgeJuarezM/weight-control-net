using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            (new FRM_TRANSPORTES()).ShowDialog();
        }

        private void oPERADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FRM_OPERADORES()).ShowDialog();
        }

        private void pESAJESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


            try
            {
                if (this.pESAJESBindingSource.Current != null)
                {
                    this.Validate();
                    this.pESAJESBindingSource.EndEdit();

                    basculaDataSet.PESAJESRow dr = (basculaDataSet.PESAJESRow)((DataRowView)this.pESAJESBindingSource.Current).Row;

                    if (dr.IsID_OPERADORNull())
                    {
                        throw new Exception("Selecciona un Operador Valido");
                    }

                    if(dr.IsID_TRANSPORTENull())
                    {
                        throw new Exception("Selecciona las placas del transporte");
                    }

                    dr.PLACAS = iD_TRANSPORTEComboBox.Text;

                    if (dr.ESTADO == "NUEVO")
                    {
                        dr.FECHA_ENTRADA = DateTime.Now;
                        dr.BAJA = false;

                        dr.ESTADO = "ABIERTO";
                        dr.PESO_ENTRADA = dr.PESO_SALIDA;
                        dr.PESO_SALIDA = 0;
                        dr.PESO_NETO = 0;
                        dr.FOLIO = (new Random(100)).Next();

                    }
                    else if (dr.ESTADO == "ABIERTO")
                    {
                        //Si estado es abierto, es una edicion, (segundo pesaje)
                        //primero se almacenan los datos de los textbox en el bindingsource

                        //despues obtenemos el dato actualizado
                        basculaDataSet.PESAJESRow drU = (basculaDataSet.PESAJESRow)((DataRowView)this.pESAJESBindingSource.Current).Row;
                        drU.PESO_NETO = drU.PESO_SALIDA - drU.PESO_ENTRADA;
                    }


                    this.tableAdapterManager.UpdateAll(this.basculaDataSet);

                    iD_OPERADORComboBox.Enabled = false;
                    iD_TRANSPORTEComboBox.Enabled = false;

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                  
            
        }

        private void FRM_PRINCIPAL_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basculaDataSet.TRANSPORTES' Puede moverla o quitarla según sea necesario.
            this.tRANSPORTESTableAdapter.Fill(this.basculaDataSet.TRANSPORTES);
            // TODO: esta línea de código carga datos en la tabla 'basculaDataSet.OPERADORES' Puede moverla o quitarla según sea necesario.
            this.oPERADORESTableAdapter.Fill(this.basculaDataSet.OPERADORES);
            // TODO: esta línea de código carga datos en la tabla 'basculaDataSet.PESAJES' Puede moverla o quitarla según sea necesario.
            this.pESAJESTableAdapter.Fill(this.basculaDataSet.PESAJES);

            

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            pESO_SALIDATextBox.ReadOnly = false;
            iD_OPERADORComboBox.Enabled = true;
            iD_TRANSPORTEComboBox.Enabled = true;

            //this.pESAJESBindingSource.AddNew();

            this.basculaDataSet.PESAJES.AddPESAJESRow(-1, DateTime.Now, DateTime.MinValue, 0, 0, 0,
                null, null, "__NUEVO__", false, "");

            pESAJESBindingSource.MoveLast();

            if (this.pESAJESBindingSource.Current != null)
            {
                basculaDataSet.PESAJESRow dr = (basculaDataSet.PESAJESRow)((DataRowView)this.pESAJESBindingSource.Current).Row;
                dr.ESTADO = "NUEVO";
                this.pESAJESBindingSource.ResetCurrentItem();
            }

            pESO_SALIDATextBox.Select();
            pESO_SALIDATextBox.Focus();
            pESO_SALIDATextBox.SelectAll();
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

                    pESO_NETOTextBox.Text = neto.ToString("0.000");
                    //dr.PESO_NETO = 0;
                }
            }


        }

       
    }
}
