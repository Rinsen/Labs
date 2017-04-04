using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rinsen.AllocationWeb.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;
using Dapper;

namespace Rinsen.AllocationWeb.Services
{
    public class SensorService
    {
        private readonly RemoteOptions _options;

        public SensorService(IOptions<RemoteOptions> options)
        {
            _options = options.Value;
        }

        public async Task<IEnumerable<ValueAndSensor>> GetAsync(string id)
        {
            using (var connection = new SqlConnection(_options.ConnectionString))
            using (var transaction = connection.BeginTransaction())
            {
                 connection.Execute("INSERT Sensors()", )

                    http://stackoverflow.com/questions/10689779/bulk-inserts-taking-longer-than-expected-using-dapper
            }
        }
    }
}
