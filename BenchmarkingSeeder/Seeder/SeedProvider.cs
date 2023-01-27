using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace BenchmarkingSeeder.Seeder
{
    public class SeedProvider
    {
        public static string DB_FILE_CSV_NAME = "Ross-Mahdavi_Oil_and_Gas_1932-2014.csv";

        public void ReadData()
        {
            var rr = new CsvFileReaderWriter();
            var data = rr.ReadFile<GasAndOilData>(DB_FILE_CSV_NAME);
        }
    }
}
