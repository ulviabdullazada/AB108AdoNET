using AdoNet.Extensions;
using AdoNet.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    class Table<T> where T : new()
    {
        static readonly string _tableName = typeof(T).Name + "s";
        public bool Add(T item)
        {
            var props = item!.GetType().GetProperties()
                .Where(x=> x.Name != "Id")
                .Select(x => x.Name);
            var values = item.GetType().GetProperties()
                .Where(x=> x.Name != "Id")
                .Select(x => x.GetValue(item));

            string query = $"INSERT INTO {_tableName}({string.Join(",", props)}) VALUES ({values.ChangeToString()})";

            return SqlHelper.Exec(query);
        }
        public List<T> ToList()
        {
            var data = SqlHelper.Read("SELECT * FROM "+ _tableName);
            List<T> result = new();
            foreach (DataRow item in data.Rows)
            {
                T obj = new();
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    var a = obj.GetType().GetProperties()[i];
                    a.SetValue(obj,item[i]);
                }
                result.Add(obj);  
            }
            return result;
        }
        public bool Delete(int id)
        {
            return SqlHelper.Exec($"DELETE {_tableName} WHERE Id = {id}");
        }
    }
}
