using BebchmarkingTool.Databases.Interfaces;

namespace BebchmarkingTool.Databases.SqlStatementsGenerator
{
    public class DeleteSQLGenerator
    {
        public string GetDeleteAllString(IModel model)
        {
            var identifierAndValuesOfModel = model.GetFieldsWithValues();

            var deleteText = $"DELETE FROM {model.GetType().Name.ToLower()}";

            return deleteText;
        }
    }
}
