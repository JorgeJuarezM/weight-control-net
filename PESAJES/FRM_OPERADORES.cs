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
    public partial class FRM_OPERADORES : Form
    {
        public FRM_OPERADORES()
        {
            InitializeComponent();
        }

        private void oPERADORESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oPERADORESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basculaDataSet);

        }

        private void FRM_OPERADORES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basculaDataSet.OPERADORES' Puede moverla o quitarla según sea necesario.
            this.oPERADORESTableAdapter.Fill(this.basculaDataSet.OPERADORES);
            // TODO: esta línea de código carga datos en la tabla 'basculaDataSet.OPERADORES' Puede moverla o quitarla según sea necesario.
            this.oPERADORESTableAdapter.Fill(this.basculaDataSet.OPERADORES);
            // TODO: esta línea de código carga datos en la tabla 'basculaDataSet.OPERADORES' Puede moverla o quitarla según sea necesario.
            this.oPERADORESTableAdapter.Fill(this.basculaDataSet.OPERADORES);

        }

        private void oPERADORESBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.oPERADORESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basculaDataSet);

        }

        private void oPERADORESBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.oPERADORESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basculaDataSet);

        }
    }
}
