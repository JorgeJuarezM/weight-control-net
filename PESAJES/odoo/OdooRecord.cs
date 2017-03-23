using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PESAJES.odoo
{
    public class OdooRecord
    {
        private readonly OdooApi __api;
        private readonly string __model;
        private readonly Dictionary<string, object> __fields = new Dictionary<string, object>();
        //private readonly List<string> __modifiedFields = new List<string>();
        int __id = -1;

        public int Id
        {
            get
            {
                return __id;
            }
        }

        public OdooRecord(OdooApi api, string modelName, int id)
        {
            this.__api = api;
            this.__model = modelName;
            this.__id = id;
        }

        public void SetValue(string field, object value)
        {
            if(__fields.ContainsKey(field))
            {
                __fields[field] = value;
            }
            else
            {
                __fields.Add(field, value);
            }
        }

        public string GetStringValue(string field)
        {
            if(__fields.ContainsKey(field))
            {
                return __fields[field].ToString();
            }
            else
            {
                throw new Exception("No existe el campo " + field);
            }
        }

        public Int32 GetIntValue(string field)
        {
            if (__fields.ContainsKey(field))
            {
                return Convert.ToInt32(__fields[field]);
            }
            else
            {
                throw new Exception("No existe el campo " + field);
            }
        }

    }
}
