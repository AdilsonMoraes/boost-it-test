using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using Npf.Process.Selections.Application.Interfaces.v1;
using Npf.Process.Selections.Application.Services.v1;
using Npf.Process.Selections.Domain.Request.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Npf.Process.Selections.Test
{
    public class ProcessElevenMultipleTest
    {
        protected Mock<IProcessElevenMultiple> _processElevenMultiple;
        private static ProcessElevenMultiple _application;

        [Fact]
        public async Task GetElevenMultipleSucess()
        {
            _application = GetApplication();
            int[] myNum = { 112233, 30800, 2937, 323455693, 5038297 };
            var request = new Request() { Number = myNum };
            var response = await _application.GetElevenMultiple(request);

            Assert.NotNull(response);
            Assert.False(response?.Results?.Any(w => !w.IsMultiple));
        }

        [Fact]
        public async Task GetElevenMultipleNotSucess()
        {
            _application = GetApplication();
            int[] myNum = { 112234 };
            var request = new Request() { Number = myNum };
            var response = await _application.GetElevenMultiple(request);

            Assert.NotNull(response);
            Assert.False(response?.Results?.Any(w => w.IsMultiple));
        }

        [Fact]
        public async Task GetElevenMultipleNull()
        {
            _application = GetApplication();
            var request = new Request();
            var response = await _application.GetElevenMultiple(request);
            Assert.True(response?.Results?.Count() == 0);
        }

        private IConfiguration CreateConfiguration()
        {
            var myConfiguration = new Dictionary<string, string>
            {
                {"Divider", "11"},
            };

            return new ConfigurationBuilder()
                .AddInMemoryCollection(myConfiguration)
                .Build();
        }

        private ProcessElevenMultiple GetApplication()
        {
            _processElevenMultiple = new Mock<IProcessElevenMultiple>();
            var mock = new Mock<ILogger<ProcessElevenMultiple>>();
            ILogger<ProcessElevenMultiple> logger = mock.Object;

            return new ProcessElevenMultiple(logger, CreateConfiguration());
        }
    }
}
