using System.Data;
using System.Data.Common;
using BebchmarkingTool.Databases.Interfaces;
using BebchmarkingTool.Databases.Utils;
using Dapper;
using static BebchmarkingTool.Databases.Cassandra;

namespace BebchmarkingTool.Databases
{
    public class DapperExecutorAdapter<ConnectionType> 
        where ConnectionType : DbConnection, new()
    {
        private readonly string _connectionString;
        private ConnectionType _connection;

        public DapperExecutorAdapter(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new ConnectionType() { ConnectionString = _connectionString };
        }

        public void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public void Create<TModel>(List<TModel> newModels, ICreateModel createModel)
            where TModel : IModel, new()
        {
            string[] createQueries = new string[newModels.Count];
            for (int i = 0; i < newModels.Count; i++)
            {
                createQueries[i] = createModel.GetCreateSqlAsString(newModels[i]);
            }

            using var trans = _connection.BeginTransaction();
            _connection.Execute(QueryBuilderHelper.CombineSqlQueriesAsOneLine(createQueries), commandTimeout: Int32.MaxValue);
            trans.Commit();
        }

        public void Delete<TModel>(List<TModel> modelsToDelete, IDeleteModel deleteModel) where TModel : IModel, new()
        {
            string[] deleteQueries = new string[modelsToDelete.Count];
            for (int i = 0; i < modelsToDelete.Count; i++)
            {
                deleteQueries[i] = deleteModel.GetDeleteSqlAsString(modelsToDelete[i]);
            }

            using (var trans = _connection.BeginTransaction())
            {
                _connection.Execute(QueryBuilderHelper.CombineSqlQueriesAsOneLine(deleteQueries), commandTimeout: Int32.MaxValue);
                trans.Commit();
            }
        }

        public void Truncate<TModel>() where TModel : IModel, new()
        {
            _connection.Execute($"TRUNCATE {typeof(TModel).Name.ToLower()};");
        }

    }
}
