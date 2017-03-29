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
    public partial class FRM_Folios : Form
    {
        public FRM_Folios()
        {
            InitializeComponent();
        }

        private void fOLIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fOLIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basculaDataSet);

        }

        private void FRM_Folios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basculaDataSet.FOLIOS' Puede moverla o quitarla según sea necesario.
            this.fOLIOSTableAdapter.Fill(this.basculaDataSet.FOLIOS);

        }
    }
}
