using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bifrost.Devices.Gpio.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace RpiSensorServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly IGpioController gpioController;

        public TestController(
            IGpioController gpioController)
        {
            this.gpioController = gpioController;
        }

        [HttpGet()]
        public IDictionary<string, string> Test()
        {
            Console.WriteLine("CALLED");
            return gpioController.Pins;
        }
    }
}
