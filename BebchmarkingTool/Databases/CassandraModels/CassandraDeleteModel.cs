using BebchmarkingTool.Databases.Interfaces;
using BebchmarkingTool.Databases.SqlStatementsGenerator;

namespace BebchmarkingTool.Databases.CassandraModels
{
    public class CassandraDeleteModel:IDeleteModel
    {
        public string GetDeleteSqlAsString(IModel model)
        {
            var generator = new DeleteSQLGenerator();
            return generator.GetDeleteAllString(model);
        }
    }
}
