using CookComputing.XmlRpc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PESAJES
{
    public interface IOdooObject : IXmlRpcProxy
    {
        [XmlRpcMethod("execute")]
        int Create(string dbName, int uid, string pwd, string obj, string method, XmlRpcStruct struc);
        [XmlRpcMethod("execute")]
        XmlRpcStruct[] Read(string dbName, int uid, string pwd, string obj, string method, int[] ids, string[] fields);
    }

    public class OdooObject
    {
        IOdooObject rpcObject;
        int user_id;
        string password;
        string obj;

        public OdooObject(int user_id, string password, string obj)
        {

            this.user_id = user_id;
            this.password = password;
            this.obj = obj;

            rpcObject = XmlRpcProxyGen.Create<IOdooObject>();
            rpcObject.Url = Properties.Settings.Default.OdooApiObjectUrl;
        }

        public OdooRecord ReadOne(int object_id, string[] fields)
        {
            OdooRecord[] __table = this.Read(new int[] { object_id}, fields);
            if(__table.Length > 0)
            {
                return __table[0];
            }
            else
            {
                return null;
            }
        }

        public OdooRecord[] Read(int[] object_ids, string[] fields)
        {
            XmlRpcStruct[] results = rpcObject.Read(Properties.Settings.Default.OdooDataBase,
                   user_id, this.password, this.obj, "read", object_ids, fields);


            OdooRecord[] records = new OdooRecord[results.Length];
            int i = 0;
            foreach(XmlRpcStruct __result in results)
            {
                records[i] = new OdooRecord(__result);
                i++;
            }


            return records;

     
        }
    }
}
