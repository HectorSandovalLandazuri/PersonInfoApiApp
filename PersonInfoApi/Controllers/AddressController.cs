using Microsoft.AspNetCore.Mvc;
using PersonInfoApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonInfoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }
        // POST api/<AddressController>
        [HttpPost]
        public void Post([FromBody] AddressModel data)
        {
            _logger.LogInformation("The Address is {Address}", data);
        }

    }
}
