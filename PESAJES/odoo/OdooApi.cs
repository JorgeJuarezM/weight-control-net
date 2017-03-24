using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PESAJES.odoo
{
    public class OdooApi
    {
        private string __username;
        private string __password;
        private int __user_id;
        private bool __is_logged;


        public int UserId {
            get
            {
                int? _check_id = this.__user_id as int?;
                if (_check_id == null) throw new Exception("El usuario no se ha autenticado");
                return this.__user_id;
            }
        }

        public string UserName
        {
            get
            {
                return this.__username;
            }
        }

        public string Password
        {
            get
            {
                return this.__password;
            }
        }

        public bool IsLogged
        {
            get 
            {
                return __is_logged;
            }
        }

        public OdooApi(string user, string password)
        {
            this.__username = user;
            this.__password = password;
            this.__is_logged = false;
        }


        public bool Login()
        {
            IOdooCommon loginObj = XmlRpcProxyGen.Create<IOdooCommon>();
            loginObj.Url = Properties.Settings.Default.OdooApiUrl + "/xmlrpc/common";
            var loginUser = loginObj.login(Properties.Settings.Default.OdooDataBase, this.__username, this.__password);

            int? responseInt = loginUser as int?;

            if(responseInt == null)
            {
                this.__is_logged = false;
            }
            else
            {
                this.__user_id = Convert.ToInt32(responseInt);
                this.__is_logged = true;
            }

            return this.__is_logged;
        }

        public OdooModel GetModel(string modelName, List<string> fields)
        {
            return new OdooModel(modelName, this, fields);
        }

        public OdooModel GetModel(string modelName)
        {
            return this.GetModel(modelName, new List<string>() { });
        }

        public Object[] Read(string modelName, int[] ids, string[] fields)
        {
            IOdooObject odooObj = XmlRpcProxyGen.Create<IOdooObject>();
            odooObj.Url = Properties.Settings.Default.OdooApiUrl + "/xmlrpc/object";

            XmlRpcStruct[] results = odooObj.Read(Properties.Settings.Default.OdooDataBase,
                this.UserId, this.Password, modelName, "read", ids, fields);

            return results;
        }

        public int[] Search(string modelName, object[] filters)
        {
            IOdooObject odooObj = XmlRpcProxyGen.Create<IOdooObject>();
            odooObj.Url = Properties.Settings.Default.OdooApiUrl + "/xmlrpc/object";

            return odooObj.search(Properties.Settings.Default.OdooDataBase,
                this.UserId, this.Password, modelName, "search", filters);
        }


        public bool Write(string model, int[] ids, XmlRpcStruct values)
        {
            IOdooObject odooObj = XmlRpcProxyGen.Create<IOdooObject>();
            odooObj.Url = Properties.Settings.Default.OdooApiUrl + "/xmlrpc/object";

            return odooObj.Write(Properties.Settings.Default.OdooDataBase,
                    this.UserId, this.Password, model, "write", ids, values);
        }

        public int Create(string model, XmlRpcStruct obj)
        {
            IOdooObject odooObj = XmlRpcProxyGen.Create<IOdooObject>();
            odooObj.Url = Properties.Settings.Default.OdooApiUrl + "/xmlrpc/object";

            return odooObj.Create(Properties.Settings.Default.OdooDataBase,
                    this.UserId, this.Password, model, "create", obj);
        }

        
    }
}
