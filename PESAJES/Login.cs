using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CookComputing.XmlRpc;
using System.Collections;

namespace PESAJES
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            try
            {
                Env.odooApi = new odoo.OdooApi(username, password);
                bool loginSuccess = Env.odooApi.Login();

                if (loginSuccess == false)
                {
                    throw new Exception("Usuario / Contraseña Incorrectos");
                }
                else
                {
                    int user_id = Env.odooApi.UserId;

                    //Obtiene usuario

                    odoo.OdooModel userModel = Env.odooApi.GetModel("res.users");
                    odoo.OdooRecord user = userModel.Browse(user_id);


                    if (user == null)
                    {
                        throw new Exception("Error al obtener informacion del usuario, intente nuevamente");
                    }
                    else
                    {
                        MessageBox.Show("Bienvenido " + user.GetStringValue("name"));
                    }
                }


                this.DialogResult = DialogResult.Yes;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtUsername.SelectAll();
        }
    }


}
