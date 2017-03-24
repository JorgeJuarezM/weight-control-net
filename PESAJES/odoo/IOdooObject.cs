using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PESAJES.odoo
{
    public interface IOdooObject: IXmlRpcProxy
    {
        [XmlRpcMethod("execute")]
        int Create(string dbName, int uid, string pwd, string obj, string method, XmlRpcStruct struc);
        [XmlRpcMethod("execute")]
        XmlRpcStruct[] Read(string dbName, int uid, string pwd, string obj, string method, int[] ids);
        [XmlRpcMethod("execute")]
        XmlRpcStruct[] Read(string dbName, int uid, string pwd, string obj, string method, int[] ids, string[] fields);
        [XmlRpcMethod("execute")]
        int[] search(string dbName, int userId, string dbPwd, string model, string method, object[] filter);
        [XmlRpcMethod("execute")]
        bool Write(string dbname, int uid, string pwd, string obj, string method, int[] ids, XmlRpcStruct strct);
    }
}
