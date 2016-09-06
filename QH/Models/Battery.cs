using System.Data.Entity;

namespace QH.Models
{
    public class Battery
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int Capacity { get; set; }
        public int Weight { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Price { get; set; }
        public int Config { get; set; }
        public double MaxDischarge { get; set; }
        public double MaxCharge { get; set; }
        public string Name { get; set; }

        public static class Lipo
        {
            public static double maxChargedVoltage = 4.2;
            public static double aveChargedVoltage = 3.7;
            public static double minChargedVoltage = 3.0;

        }
    }

    public enum BatteryConfig
    {
        s1 = 1,
        s2 = 2,
        s3 = 3,
        s4 = 4,
        s6 = 6,
        s8 = 8
    }
}