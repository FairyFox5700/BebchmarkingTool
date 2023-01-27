namespace BebchmarkingTool.Databases.Interfaces
{
    public interface IModel
    {
        string GetPrimaryKeyFieldName();
        Dictionary<string, object> GetFieldsWithValues();
    }
}
