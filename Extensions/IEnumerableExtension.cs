using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Extensions
{
    static class IEnumerableExtension
    {
        public static string ChangeToString(this IEnumerable<object> list)
        {
            StringBuilder sb = new StringBuilder();
            string delimiter = "";
            foreach (var item in list)
            {
                sb.Append(delimiter);
                if (item is string)
                {
                    sb.Append($"N'{item}'");
                }
                else if (item is int)
                {
                    sb.Append(item);
                }
                else if (item is bool res) 
                {
                    sb.Append(res ? "1" : "0");
                }
                else if (item is null)
                {
                    sb.Append("NULL");
                }
                else
                {
                    sb.Append(item);
                }
                delimiter = ",";
            }
            return string.Join(",", sb);
        }
    }
}
