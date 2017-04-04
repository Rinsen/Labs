using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rinsen.AllocationWeb.Entities
{
    public class SensorValue
    {
        public int SensorValueId { get; set; }

        public int SensorId { get; set; }

        public int Value { get; set; }

        public DateTimeOffset Timestamp { get; set; }

    }
}
