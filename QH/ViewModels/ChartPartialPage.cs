using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using QH.Models;

namespace QH.ViewModels
{

    public class ChartPartialPage
    {
        public SortedDictionary<AxisType, Func<Battery, double>> AxisDataFormatMethods = new SortedDictionary<AxisType, Func<Battery, double>>();
        public SortedDictionary<AxisType,  string> AxisLabels = new SortedDictionary<AxisType, string>();

        public ChartPartialPage()
        {
            AxisDataFormatMethods.Add(AxisType.Capacity, CapacityAxisDataFormatMethods);
            AxisDataFormatMethods.Add(AxisType.Config, ConfigAxisDataFormatMethods);
            AxisDataFormatMethods.Add(AxisType.Weight, WeightAxisDataFormatMethods);
            AxisDataFormatMethods.Add(AxisType.Volume, VolumeAxisDataFormatMethods);
            AxisDataFormatMethods.Add(AxisType.Discharge, DischargeAxisDataFormatMethods);
            AxisDataFormatMethods.Add(AxisType.Charge, ChargeAxisDataFormatMethods);
            AxisDataFormatMethods.Add(AxisType.Price, PriceAxisDataFormatMethods);
            AxisDataFormatMethods.Add(AxisType.Energy, EnergyAxisDataFormatMethods);

            AxisLabels.Add(AxisType.Capacity, "Capacity (mah)");
            AxisLabels.Add(AxisType.Config, "Config (#s)");
            AxisLabels.Add(AxisType.Weight, "Weight (g)");
            AxisLabels.Add(AxisType.Volume, "Volume (mm^3)");
            AxisLabels.Add(AxisType.Discharge, "Discharge (C)");
            AxisLabels.Add(AxisType.Charge, "Charge (C)");
            AxisLabels.Add(AxisType.Price, "Price ($)");
            AxisLabels.Add(AxisType.Energy, "energy (Wh)");

            // defaults remove 
            XAxis = AxisType.Energy;
            YAxis = AxisType.Price;
        }
        public AxisType XAxis { get; set; }
        public AxisType YAxis { get; set; }




        public string GetBatteryChartData(List<Battery> batteries)
        {
            double [][] ret = new double[batteries.Count][];
            for (int i = 0; i < batteries.Count; i++)
            {
                ret[i] = new double[] { AxisDataFormatMethods[XAxis](batteries[i]), AxisDataFormatMethods[YAxis](batteries[i]) };
            }
            //return ret;
            var javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            return javaScriptSerializer.Serialize(ret);
        }
        
        public string GetXAxisLabel()
        {
            return AxisLabels[XAxis];
        }
        public string GetYAxisLabel()
        {
            return AxisLabels[YAxis];
        }

        public string GetChartTitle()
        {
            return AxisLabels[XAxis] + " vs. " + AxisLabels[YAxis];
        }

        // formatting functions for specific axis selections

        private double ConfigAxisDataFormatMethods(Battery b)
        {
            return b.Config;
        }
        private double CapacityAxisDataFormatMethods(Battery b)
        {
            return b.Capacity;
        }
        private double WeightAxisDataFormatMethods(Battery b)
        {
            return b.Weight;
        }
        private double VolumeAxisDataFormatMethods(Battery b)
        {
            return Math.Round(b.Length * b.Height * b.Width, 2);
        }
        private double DischargeAxisDataFormatMethods(Battery b)
        {
            return b.MaxDischarge;
        }
        private double ChargeAxisDataFormatMethods(Battery b)
        {
            return b.MaxCharge;
        }
        private double PriceAxisDataFormatMethods(Battery b)
        {
            return b.Price;
        }
        private double EnergyAxisDataFormatMethods(Battery b)
        {
            // Amp hours * Voltage
            return Math.Round((b.Capacity/1000) * ((int)b.Config * Battery.Lipo.maxChargedVoltage));
        }
    }


    public enum AxisType
    {
        Config,
        Capacity,
        Weight,
        Volume,
        Discharge,
        Charge,
        Price,
        Energy
    }
}