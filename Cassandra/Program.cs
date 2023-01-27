namespace Cassandra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cluster = Cluster.Builder()
                .AddContactPoints("node-0.gce_us_central_1.1749f432c67e6f949a27.clusters.scylla.cloud", "node-1.gce_us_central_1.1749f432c67e6f949a27.clusters.scylla.cloud", "node-2.gce_us_central_1.1749f432c67e6f949a27.clusters.scylla.cloud")
              //  .WithPort(9042)
              
                .WithAuthProvider(new PlainTextAuthProvider("scylla", "Jbvn51xEtai2PUr"))
                .Build();


            var session =  cluster.Connect();
            session.Execute("CREATE KEYSPACE mykeyspace WITH replication = {'class': 'NetworkTopologyStrategy', 'GCE_US_CENTRAL_1' : 3} AND durable_writes = true;\r\nUSE mykeyspace;");

            session = cluster.Connect("mykeyspace");

            session.Execute("USE mykeyspace;\r\n    \r\nCREATE TABLE monkeySpecies (\r\n    species text PRIMARY KEY,\r\n    common_name text,\r\n    population varint,\r\n    average_size int\r\n);\r\nINSERT INTO monkeySpecies (species, common_name, population, average_size) VALUES ('Saguinus niger', 'Black tamarin', 10000, 500);\r\nSELECT * FROM monkeySpecies;");
            Console.WriteLine("Hello, World!");
        }
    }
}