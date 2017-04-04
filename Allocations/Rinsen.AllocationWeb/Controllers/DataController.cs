using Microsoft.AspNetCore.Mvc;
using Rinsen.AllocationWeb.Models;
using Rinsen.AllocationWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rinsen.AllocationWeb.Controllers
{
    public class DataController : Controller
    {
        private readonly SensorService _sensorService;

        public DataController(SensorService sensorService)
        {
            _sensorService = sensorService;
        }

        public async Task<IEnumerable<ValueAndSensor>> Get(string id)
        {
            return await _sensorService.GetAsync(id);
        }

    }
}
