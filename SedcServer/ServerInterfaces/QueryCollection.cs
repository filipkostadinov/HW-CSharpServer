using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerInterfaces
{
    public class QueryCollection
    {
        private readonly List<KeyValuePair<string,string>> data = new List<KeyValuePair<string, string>>();

        public QueryCollection(List<KeyValuePair<string, string>> initialData)
        {
            data = initialData;
        }

        public static QueryCollection Empty
        {
            get
            {
                return new QueryCollection(new List<KeyValuePair<string, string>>());
            }
        }

        public override string ToString()
        {    
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Count; i++)
            {
                sb.Append(i == data.Count - 1 ? $"{data[i].Key}={data[i].Value}" : $"{data[i].Key}={data[i].Value}&");
            }
            return sb.ToString();
        }
    }
}