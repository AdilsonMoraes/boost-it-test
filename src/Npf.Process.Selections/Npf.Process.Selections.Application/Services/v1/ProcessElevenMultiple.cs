using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Npf.Process.Selections.Application.Interfaces.v1;
using Npf.Process.Selections.Domain.Models.v1;
using Npf.Process.Selections.Domain.Request.v1;
using Npf.Process.Selections.Domain.Response.v1;
using System.Runtime.CompilerServices;

namespace Npf.Process.Selections.Application.Services.v1
{
    public class ProcessElevenMultiple : IProcessElevenMultiple
    {
        private readonly ILogger<ProcessElevenMultiple> _logger;
        private readonly IConfiguration _configuration;       

        static string GetActualAsyncMethodName([CallerMemberName] string name = null) => name;

        public ProcessElevenMultiple(ILogger<ProcessElevenMultiple> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public async Task<Response> GetElevenMultiple(Request numbers)
        {
            var methodName = GetActualAsyncMethodName();
            var response = new Response()
            {
                Results = new List<Results>()
            };

            try
            {
                _logger.LogInformation($"Start {GetActualAsyncMethodName}");
                if (numbers?.Number == null)
                {
                    _logger.LogInformation($"number into request IS NULL, please, fix request and retry!");
                    return response;
                }

                _logger.LogInformation($"Set div value with base Divider enviroment variable");
                var div = Int16.Parse(_configuration.GetSection("Divider").Value);
                
                await Task.Run(() => Parallel.ForEach(numbers.Number, number =>
                {
                    response.Results.Add(new Results() { Number = number, IsMultiple = (number % div).Equals(0) });
                }));
                _logger.LogInformation($"End {GetActualAsyncMethodName}");
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, $"An error was occurred in {methodName}");
            }

            return response;

        }
    }
}
