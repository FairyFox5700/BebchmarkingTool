using System.Text;

namespace BebchmarkingTool.Databases.Utils
{
    public class QueryBuilderHelper
    {
        public static string CombineSqlQueriesAsOneLine(string[] queries)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < queries.Length; i++)
            {
                sb.Append(queries[i]);
            }

            return sb.ToString();
        }

        public static string EscapeString(object value)
        {
            var type = value.GetType();

            if (type == typeof(String)) return $"'{value}'";
            else return value.ToString();
        }
    }
}
