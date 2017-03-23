using CookComputing.XmlRpc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public Hashtable ReadOne(int object_id, string[] fields)
        {
            List<Hashtable> __table = this.Read(new int[] { object_id }, fields);
            if(__table.Count > 0)
            {
                return __table[0];
            }
            else
            {
                return null;
            }
        }

        public List<Hashtable> Read(int[] object_ids, string[] fields)
        {
            List<Hashtable> __table = new List<Hashtable>();

            XmlRpcStruct[] results = rpcObject.Read(Properties.Settings.Default.OdooDataBase,
                   user_id, this.password, this.obj, "read", object_ids, fields);



            foreach(XmlRpcStruct result in results)
            {
                Hashtable __tbl = new Hashtable();
                IEnumerator enKeys = result.Keys.GetEnumerator();
                IEnumerator enValues = result.Values.GetEnumerator();

                for (int __i = 0; __i < result.Keys.Count; __i++)
                {
                    
                    enKeys.MoveNext();
                    string __key = (string)enKeys.Current;

                    enValues.MoveNext();
                    var __value = enValues.Current;

                    __tbl.Add(__key, __value);
                }

                __table.Add(__tbl);
            }

            return __table;
        }
    }
}
