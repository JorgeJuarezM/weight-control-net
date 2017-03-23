using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PESAJES
{
    public class OdooRecord
    {
        private XmlRpcStruct __struc;

        public OdooRecord()
        {
            this.__struc = new XmlRpcStruct();
        }

        public OdooRecord(XmlRpcStruct __structure)
        {
            this.__struc = __structure;
        }


        public string GetStringValue(string key)
        {
            return this.__struc[key].ToString();
        }
    }
}
