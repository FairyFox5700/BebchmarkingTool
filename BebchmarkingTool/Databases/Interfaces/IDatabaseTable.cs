namespace BebchmarkingTool.Databases.Interfaces
{
    public interface IDatabaseTable<TModel> where TModel: IModel, new()
    {
        public string GenerateTableCreationSQL();
    }
}
