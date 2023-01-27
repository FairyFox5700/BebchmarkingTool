using CsvHelper.Configuration;

namespace BenchmarkingSeeder.Seeder
{
    public class GasAndOilData
    {
        public string cty_name { get; set; }
        public int iso3numeric { get; set; }
        public string id { get; set; }
        public int year { get; set; }
        public string eiacty { get; set; }
        public string oil_prod32_14 { get; set; }
        public double oil_price_2000 { get; set; }
        public double oil_price_nom { get; set; }
        public string oil_value_nom { get; set; }
        public string oil_value_2000 { get; set; }
        public string oil_value_2014 { get; set; }
        public string gas_prod55_14 { get; set; }
        public double gas_price_2000_mboe { get; set; }
        public string gas_price_2000 { get; set; }
        public double gas_price_nom { get; set; }
        public string gas_value_nom { get; set; }
        public string gas_value_2000 { get; set; }
        public string gas_value_2014 { get; set; }
        public string oil_gas_value_nom { get; set; }
        public string oil_gas_value_2000 { get; set; }
        public string oil_gas_value_2014 { get; set; }
        public string oil_gas_valuePOP_nom { get; set; }
        public string oil_gas_valuePOP_2000 { get; set; }
        public string oil_gas_valuePOP_2014 { get; set; }
        public string oil_exports { get; set; }
        public string net_oil_exports { get; set; }
        public string net_oil_exports_mt { get; set; }
        public string net_oil_exports_value { get; set; }
        public string net_oil_exports_valuePOP { get; set; }
        public string gas_exports { get; set; }
        public string net_gas_exports_bcf { get; set; }
        public string net_gas_exports_mboe { get; set; }
        public string net_gas_exports_value { get; set; }
        public string net_gas_exports_valuePOP { get; set; }
        public string net_oil_gas_exports_valuePOP { get; set; }
        public double? population { get; set; }
        public double? pop_maddison { get; set; }
        public int sovereign { get; set; }
        public double mult_nom_2000 { get; set; }
        public double mult_nom_2014 { get; set; }
        public double mult_2000_2014 { get; set; }
    }
}
