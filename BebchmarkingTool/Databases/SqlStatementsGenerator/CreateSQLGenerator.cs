using BebchmarkingTool.Databases.Interfaces;
using BebchmarkingTool.Databases.Utils;

namespace BebchmarkingTool.Databases.SqlStatementsGenerator
{
    public class CreateSQLGenerator
    {
        public string GerCreateSqlString(IModel model)
        {
            var modelColumnsAndValuesDict = model.GetFieldsWithValues();
            var keys = string.Join(", ", modelColumnsAndValuesDict.Keys);
            var values = string.Join(", ", modelColumnsAndValuesDict.Values.Select(QueryBuilderHelper.EscapeString));

            var sql =
                $@"INSERT INTO {model.GetType().Name.ToLower()} ({keys}) VALUES(@{values}) SELECT CAST(scope_identity() AS int);";

            return sql;
        }
    }
}
