using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            Type t = value.GetType();
            if (t == (new Object[] { }).GetType())
            {

                Object[] values = (Object[])value;
                if(values.Length > 0)
                {
                    value = values[0];
                }
                else
                {
                    value = null;
                }
                
            }
            

            /***************************/

            if (__fields.ContainsKey(field))
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

        public DateTime GetDateTimeValue(string field)
        {
            if (__fields.ContainsKey(field))
            {
                return Convert.ToDateTime(__fields[field]);
            }
            else
            {
                throw new Exception("No existe el campo " + field);
            }
        }

        public Decimal GetDecimalValue(string field)
        {
            if (__fields.ContainsKey(field))
            {
                return Convert.ToDecimal(__fields[field]);
            }
            else
            {
                throw new Exception("No existe el campo " + field);
            }
        }


        public void Save()
        {
            XmlRpcStruct values = new XmlRpcStruct();

            foreach (KeyValuePair<string, object> field in __fields)
            {
                values[field.Key] = field.Value;
            }

            if (__id > 0)
            {
                //ya existe
                __api.Write(__model, new int[] { __id }, values);
            }
            else
            {
                __id = __api.Create(__model, values);
            }
        }

    }
}
