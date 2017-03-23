using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PESAJES.odoo
{
    public interface IOdooCommon: IXmlRpcProxy
    {
        [XmlRpcMethod("login")]
        object login(string dbName, string dbUser, string dbPassword);
    }
}
