using static BebchmarkingTool.Databases.Cassandra;

namespace BebchmarkingTool.Databases.Interfaces
{
    public interface ICreateModel
    {
        public string GetCreateSqlAsString(IModel model);
    }
}
