using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PESAJES.odoo
{
    public class OdooModel
    {
        private string __modelName;
        private OdooApi __api;
        private List<string> __fields = new List<string>();


        public OdooModel(string modelName, OdooApi api)
        {
            this.__modelName = modelName;
            this.__api = api;
        }

        public OdooModel(string modelName, OdooApi api, List<string> fields)
            : this(modelName, api)
        {
            this.AddFields(fields);
        }

        public OdooRecord Browse(int id)
        {
            List<OdooRecord> __records = this.Browse(new int[] { id });
            if(__records.Count > 0)
            {
                return __records[0];
            }
            else
            {
                return null;
            }
        }

        public List<OdooRecord> Search(object[] filters = null)
        {
            filters = filters ?? new object[] { };

            int[] ids = __api.Search(__modelName, filters);
            return this.Browse(ids);

        }

        public List<OdooRecord> Browse(int[] ids)
        {
            List<OdooRecord> records = new List<OdooRecord>();

            object[] result = __api.Read(__modelName, ids, __fields.ToArray());
            foreach(object entry in result)
            {
                XmlRpcStruct vals = (XmlRpcStruct)entry;
                int id = (int)vals["id"];

                OdooRecord record = new OdooRecord(__api, __modelName, id);

                if(__fields.Count > 0)
                {
                    foreach (string field in __fields)
                    {
                        record.SetValue(field, vals[field]);
                    }
                }
                else
                {
                    foreach(string __key in vals.Keys)
                    {
                        record.SetValue(__key, vals[__key]);
                    }
                }

                records.Add(record);
            }

            return records;
        }


        public void AddField(string field)
        {
            if(!__fields.Contains(field))
            {
                __fields.Add(field);
            }
        }

        public void AddFields(List<string> fields)
        {
            foreach(string field in fields)
            {
                this.AddField(field);
            }
        }


    }
}
