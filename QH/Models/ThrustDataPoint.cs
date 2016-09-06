using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace QH.Models
{
    public class ThrustDataPoint
    {
        [Key]
        public int Id { get; set; }
        public double PropDiameter { get; set; }
        public double PropPitch { get; set; }
        public double Voltage { get; set; }
        public double Current { get; set; }
        public double Thrust { get; set; }

        public int MotorId { get; set; }
        [ForeignKey("MotorId")]
        public virtual Motor Motor { get; set; }
    }

}