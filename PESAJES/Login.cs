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
using System.Security.Cryptography;

namespace PESAJES
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool loginLocal(string username, string password)
        {
            string clave = getHash(password);

            basculaDataSetTableAdapters.USUARIOSTableAdapter ta = new basculaDataSetTableAdapters.USUARIOSTableAdapter();
            int existeLogin = (int)ta.ExisteLogin(username, clave);

            if(existeLogin > 0)
            {
                int userId = (int)ta.GetID(username, clave);
                DateTime ultimo_acceso = (DateTime)ta.UltimoAcceso(userId);

                DateTime ahora = DateTime.Now;

                int days = (ahora - ultimo_acceso).Days;
                return days < 2;
            }else
            {
                return false;
            }
        }

        private string getHash(string salt)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] passBytes = Encoding.UTF8.GetBytes(salt);
            byte[] hash = sha1.ComputeHash(passBytes);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }

        private void updateUserPassword(int userId, string password, string username)
        {

            string clave = getHash(password);
            basculaDataSetTableAdapters.USUARIOSTableAdapter ta = new basculaDataSetTableAdapters.USUARIOSTableAdapter();


            int existe = (int)ta.ExisteUsuario(userId);
            if(existe == 0)
            {
                ta.Insert(userId, username, clave, DateTime.Now);
            }
            else
            {
                ta.UpdateUser(clave, username, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), userId);
            }
            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            try
            {
                Env.odooApi = new odoo.OdooApi(username, password);
                bool loginSuccess = false;

                try
                {
                    loginSuccess = Env.odooApi.Login();

                    if (loginSuccess)
                    {
                        this.updateUserPassword(Env.odooApi.UserId, password, username);
                    }
                }
                catch(Exception)
                {
                    //Intentar de modo local
                    loginSuccess = this.loginLocal(username, password);
                }

                if (loginSuccess == false)
                {
                    throw new Exception("Usuario / Contraseña Incorrectos");
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
