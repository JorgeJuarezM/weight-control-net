using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PESAJES
{
    public partial class FRM_Config : Form
    {
        public FRM_Config()
        {
            InitializeComponent();
        }

        private void FRM_Config_Load(object sender, EventArgs e)
        {
            txtApiURL.Text = Properties.Settings.Default.OdooApiUrl;
            txtBDD.Text = Properties.Settings.Default.OdooDataBase;
            txtPuerto.Text = Properties.Settings.Default.PuertoCOM;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["OdooApiUrl"] = txtApiURL.Text;
            Properties.Settings.Default["OdooDataBase"] = txtBDD.Text;
            Properties.Settings.Default["PuertoCOM"] = txtPuerto.Text;

            Properties.Settings.Default.Save();

            MessageBox.Show("Parametros Guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            (new FRM_Folios()).ShowDialog();
        }
    }
}
