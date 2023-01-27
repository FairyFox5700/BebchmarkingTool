using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace BenchmarkingSeeder.Seeder
{
    public class CsvFileReaderWriter
    {
        public List<TModel> ReadFile<TModel>(string fileName)
        {
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                Delimiter = "\t",
            };

            using var reader = new StreamReader(fileName);
            using var csv = new CsvReader(reader, configuration);
         
            var records = csv.GetRecords<TModel>();
            return records?.ToList() ?? new List<TModel>();
        }

        public void WriteCsv<TModel>(List<TModel> values, string fileName)
        {
            using var writer = new StreamWriter(fileName);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(values);
        }
    }
}
