using CsvHelper.Configuration;

namespace BenchmarkingSeeder.Seeder;

public class GasAndOilDataMap : ClassMap<GasAndOilData>
{
    public GasAndOilDataMap()
    {
       /* Map(m => m.CtyName).Name("cty_name");
        Map(m => m.Iso3numeric).Name("iso3numeric");
        Map(m => m.Id).Name("id");
        Map(m => m.Year).Name("year");
        Map(m => m.Eiacty).Name("eiacty");
        Map(m => m.OilProd3214).Name("oil_prod32_14");
        Map(m => m.OilPrice2000).Name("oil_price_2000");
        Map(m => m.OilPriceNom).Name("oil_price_nom");
        Map(m => m.OilValueNom).Name("oil_value_nom");
        Map(m => m.OilValue2000).Name("oil_value_2000");
        Map(m => m.OilValue2014).Name("oil_value_2014");
        Map(m => m.GasProd5514).Name("gas_prod55_14");
        Map(m => m.GasPrice2000Mboe).Name("gas_price_2000_mboe");
        Map(m => m.GasPrice2000).Name("gas_price_2000");
        Map(m => m.GasPriceNom).Name("gas_price_nom");
        Map(m => m.GasValueNom).Name("gas_value_nom");
        Map(m => m.GasValue2000).Name("gas_value_2000");
        Map(m => m.GasValue2014).Name("gas_value_2014");
        Map(m => m.OilGasValueNom).Name("oil_gas_value_nom");
        Map(m => m.OilGasValue2000).Name("oil_gas_value_2000");
        Map(m => m.OilGasValue2014).Name("oil_gas_value_2014");
        Map(m => m.OilGasValuePOPNom).Name("oil_gas_valuePOP_nom");
        Map(m => m.OilGasValuePOP2000).Name("oil_gas_valuePOP_2000");
        Map(m => m.OilGasValuePOP2014).Name("oil_gas_valuePOP_2014");
        Map(m => m.OilExports).Name("oil_exports");
        Map(m => m.NetOilExports).Name("net_oil_exports");
        Map(m => m.NetOilExportsMt).Name("net_oil_exports_mt");
        Map(m => m.NetOilExportsValue).Name("net_oil_exports_value");
        Map(m => m.NetOilExportsValuePOP).Name("net_oil_exports_valuePOP");
        Map(m => m.GasExports).Name("gas_exports");
        Map(m => m.NetGasExportsBcf).Name("net_gas_exports_bcf");
        Map(m => m.NetGasExportsMboe).Name("net_gas_exports_mboe");
        Map(m => m.NetGasExportsValue).Name("net_gas_exports_value");
        Map(m => m.NetGasExportsValuePOP).Name("net_gas_exports_valuePOP");
        Map(m => m.NetOilGasExportsValuePOP).Name("net_oil_gas_exports_valuePOP");
        Map(m => m.Population).Name("population");
        Map(m => m.PopMaddison).Name("pop_maddison");
        Map(m => m.Sovereign).Name("sovereign");
        Map(m => m.MultNom2000).Name("mult_nom_2000");
        Map(m => m.MultNom2014).Name("mult_nom_2014");
        Map(m => m.Mult20002014).Name("mult_2000_2014");*/
    }
}