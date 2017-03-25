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
    public partial class Frm_PreguntaActualiza : Form
    {
        int segundos = 10;
        public Frm_PreguntaActualiza()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos--;
            lblSeconds.Text = segundos.ToString();


            if(segundos <= 0)
            {
                timer1.Enabled = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
                (new FRM_Actualiza()).ShowDialog();
                Env.intentos_actualiza = 0;
            }

        }

        private void Frm_PreguntaActualiza_Load(object sender, EventArgs e)
        {
            lblSeconds.Text = segundos.ToString();
            if(Env.intentos_actualiza >= 5)
            {
                btnCancelar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Env.intentos_actualiza++;
            timer1.Enabled = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
