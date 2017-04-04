using Rinsen.AllocationWeb.Entities;
using Rinsen.DatabaseInstaller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rinsen.AllocationWeb.DatabaseInstaller
{
    public class DataModel_01 : DatabaseVersion
    {
        public DataModel_01()
            : base(1)
        {
        }

        public override void AddDbChanges(List<IDbChange> dbChangeList)
        {
            var sensorTable = dbChangeList.AddNewTable<Sensor>();

            sensorTable.AddAutoIncrementColumn(m => m.SensorId);
            sensorTable.AddColumn(m => m.Name);
            sensorTable.AddColumn(m => m.Created);
            sensorTable.AddColumn(m => m.Updated);

            var sensorValuesTable = dbChangeList.AddNewTable<SensorValue>();
            sensorValuesTable.AddAutoIncrementColumn(m => m.SensorValueId);
            sensorValuesTable.AddColumn(m => m.SensorId).ForeignKey<Sensor>(m => m.SensorId);
            sensorValuesTable.AddColumn(m => m.Timestamp);
            sensorValuesTable.AddColumn(m => m.Value);

            //var uixSensorValueTable = dbChangeList.AddNewUniqueIndex<SensorValue>("uix_SensorValue");
            //uixSensorValueTable.AddColumn(m => m.SensorId);
            //uixSensorValueTable.AddColumn(m => m.Timestamp);
        }
    }
}
