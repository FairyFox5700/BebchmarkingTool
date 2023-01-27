using System.Diagnostics.Metrics;
using BebchmarkingTool.Databases.Interfaces;
using Cassandra;
using Cassandra.Mapping;
using ISession = Cassandra.ISession;

namespace BebchmarkingTool.Databases
{
    public class Cassandra
    {
        public readonly string KEYSPACE_NAME = "benchmarkdb";

        private readonly int BATCH_SIZE = 10;
        private readonly string _connectionString;

        private readonly Cluster _cassandraCluster;
        private readonly ISession _cassandraSession;
        private readonly IMapper _cassandraMapper;

        public Cassandra(string connectionString)
        {
            _connectionString = connectionString;

            var consistencyLevel = ConsistencyLevel.One;
            var queryOptions = new QueryOptions();
            queryOptions.SetConsistencyLevel(consistencyLevel);

            var builder = Cluster.Builder()
                .WithConnectionString(_connectionString)
                .WithQueryOptions(queryOptions);

            _cassandraCluster = builder.Build();
            _cassandraSession = _cassandraCluster.Connect(KEYSPACE_NAME);
            _cassandraMapper = new Mapper(_cassandraSession);
        }

        public async Task<IEnumerable<string>> GetAllTableNames()
        {
            var query = $"SELECT table_name FROM system_schema.tables WHERE keyspace_name = '{this.KEYSPACE_NAME}';";
            return  await _cassandraMapper.FetchAsync<string>(query);
        }

        public async Task CreateCollectionIfNotExists<TModel>(IDatabaseTable<TModel> createCollectionModel) 
            where TModel : IModel, new()
        {
            if ((await GetAllTableNames()).Contains(typeof(TModel).Name.ToLower()) == false)
            {
                var createCollectionTable = createCollectionModel.GenerateTableCreationSQL();
                await _cassandraMapper.ExecuteAsync(createCollectionTable);
            }
        }

        public async Task Create<TModel>(List<TModel> newModels, ICreateModel createModel) where TModel : IModel, new()
        {
            var tasks = new List<Task>();
            var queries = newModels.Select(m => createModel.GetCreateSqlAsString(m)).ToList();

            queries.ForEach(b =>
            {
                var task = _cassandraMapper.ExecuteAsync(b);
                tasks.Add(task);
            });

            await Task.WhenAll(tasks).ConfigureAwait(false);
        }
    }
}
