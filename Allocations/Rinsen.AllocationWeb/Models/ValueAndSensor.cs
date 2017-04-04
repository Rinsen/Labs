using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rinsen.AllocationWeb.Models
{
    public class ValueAndSensor
    {
        public int SensorId { get; set; }

        public string Name { get; set; }

        public int Value { get; set; }

        public DateTimeOffset Timestamp { get; set; }
    }
}
