using AutoFac_Sample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoDac_Sample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;

        public HomeController(ICustomerService customerService, IProductService productService)
        {
            _customerService = customerService;
            _productService = productService;
        }

        [HttpGet("{id}")]
        public IActionResult DoTest([FromRoute] int id)
        {
            var result = _customerService.DoSum(id);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult DoMultipe([FromRoute] int id)
        {
            var result =  _productService.DoMultiple(id);

            return Ok(result);
        }
    }
}
