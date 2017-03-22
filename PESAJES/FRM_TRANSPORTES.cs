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
    public partial class FRM_TRANSPORTES : Form
    {
        public FRM_TRANSPORTES()
        {
            InitializeComponent();
        }

        private void tRANSPORTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRANSPORTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basculaDataSet);

        }

        private void FRM_TRANSPORTES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basculaDataSet.TRANSPORTES' Puede moverla o quitarla según sea necesario.
            this.tRANSPORTESTableAdapter.Fill(this.basculaDataSet.TRANSPORTES);

        }
    }
}
