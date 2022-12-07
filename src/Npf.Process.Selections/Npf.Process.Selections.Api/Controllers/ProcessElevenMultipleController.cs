using Microsoft.AspNetCore.Mvc;
using Npf.Process.Selections.Application.Interfaces.v1;
using Npf.Process.Selections.Domain.Request.v1;
using Npf.Process.Selections.Domain.Response.v1;

namespace Npf.Process.Selections.Api.Controllers
{    
    [Route("api/")]
    [ApiController]
    public class ProcessElevenMultipleController : Controller
    {
        private readonly IProcessElevenMultiple _processElevenMultiple;

        public ProcessElevenMultipleController(IProcessElevenMultiple processElevenMultiple)
        {
            _processElevenMultiple = processElevenMultiple;

        }

        [Route("ProcessElevenMultiple/ProcessNumbers")]
        [HttpPost]
        public async Task<Response> ProcessNumbers([FromBody] Request numbers) 
            => await Task.Run(() => _processElevenMultiple.GetElevenMultiple(numbers));                   
        
    }
}
