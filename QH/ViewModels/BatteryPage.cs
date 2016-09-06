using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QH.ViewModels
{
    public class BatteryPage
    {

        public BatteryPage()
        {
            name = "";
            ChartPartialPage = new ChartPartialPage();
        }

        public ChartPartialPage ChartPartialPage { get; set; }
        public List<QH.Models.Battery> Batteries { get; set; }
        public string name { get; set; }
        [EnumDataType(typeof(Models.BatteryConfig))]
        public Models.BatteryConfig? minConfig { get; set; }
        [EnumDataType(typeof(Models.BatteryConfig))]
        public Models.BatteryConfig? maxConfig { get; set; }
        public int? minCapacity { get; set; }
        public int? maxCapacity { get; set; }
        public int? minWeight { get; set; }
        public int? maxWeight { get; set; }
        public double? minVolume { get; set; }
        public double? maxVolume { get; set; }
        public double? minDischarge { get; set; }
        public double? maxDischarge { get; set; }
        public double? minCharge { get; set; }
        public double? maxCharge { get; set; }
        public double? minPrice { get; set; }
        public double? maxPrice { get; set; }

    }
}