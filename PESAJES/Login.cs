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
                IOdooLogin rpcLogin = XmlRpcProxyGen.Create<IOdooLogin>();
                rpcLogin.Url = Properties.Settings.Default.OdooApiUrl;
                var loginUser = rpcLogin.login(Properties.Settings.Default.OdooDataBase, username, password);

                bool? responseBool = loginUser as bool?;
                int? responseInt = loginUser as int?;

                if (responseBool == false)
                {
                    throw new Exception("Usuario / Contraseña Incorrectos");
                }
                else if (responseInt != null)
                {
                    int user_id = Convert.ToInt32(responseInt);

                    //Obtiene usuario

                    OdooObject objUsers = new OdooObject(user_id, password, "res.users");
                    OdooRecord user = objUsers.ReadOne(user_id, new string[] { "id", "name" });
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

    //[XmlRpcUrl("http://192.168.2.25:8069/xmlrpc/common")]
    public interface IOdooLogin: IXmlRpcProxy
    {
        [XmlRpcMethod("login")]
        object login(string dbName, string dbUser, string dbPassword);
    }


}
