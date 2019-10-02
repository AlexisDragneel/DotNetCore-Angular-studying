using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_TEST.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TestController : Controller
    {

        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet("module")]
        public int RecursiveModule(int dividendo, int divisor)
        {
            return _testService.RecursiveModule(dividendo, divisor);
        }

        [HttpGet("max")]
        public int MaxRecursive([FromQuery]int[] list)
        {
            return _testService.MaxRecursive(list);
        }

        [HttpGet("chairString")]
        public List<string> RecursiveChairString(string input)
        {
            return _testService.RecursiveChairString(input);
        }

        [HttpGet("chairSubString")]
        public List<string> RecursiveChairSubString(string input)
        {
            return _testService.RecursiveChairSubString(input);
        }
    }
}