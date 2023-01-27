using BebchmarkingTool.Databases.Interfaces;
using BebchmarkingTool.Databases.SqlStatementsGenerator;
using BebchmarkingTool.Databases.Utils;

namespace BebchmarkingTool.Databases.CassandraModels
{
    public class CassandraAddModel : ICreateModel
    {
        public string GetCreateSqlAsString(IModel model)
        {
            var sqlCreateModel = new CreateSQLGenerator();
            return sqlCreateModel.GerCreateSqlString(model);
        }
    }
}
