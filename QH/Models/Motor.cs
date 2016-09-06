using System.Collections.Generic;
using System.Data.Entity;

namespace QH.Models
{
    public class Motor
    {
        public int Id { get; set; }
        public int Kv { get; set; }
        public string Url { get; set; }
        public double Weight { get; set; }
        public double Shaft { get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }
        public double CanLength { get; set; }
        public double TotalLength { get; set; }
        public double Price { get; set; }
        public double MaxCurrent { get; set; }
        public double MaxVoltage { get; set; }
        public string Name { get; set; }

        public ICollection<ThrustDataPoint> ThrustData { get; set; }
    }
}