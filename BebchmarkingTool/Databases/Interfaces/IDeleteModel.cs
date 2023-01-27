using static BebchmarkingTool.Databases.Cassandra;

namespace BebchmarkingTool.Databases.Interfaces
{
    public interface IDeleteModel
    {
        public string GetDeleteSqlAsString(IModel model);
    }
}
