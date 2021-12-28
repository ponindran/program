using Microsoft.Extensions.Logging;
using System;

namespace Store.Logging
{
    public class Logwrapper<T> : ILogwrapper<T> where T : class
    {
        protected readonly ILogger<T> _logger;
        public Logwrapper(ILogger<T> logger)
        {
            _logger = logger;
        }

        public void Debug(string message)
        {
            _logger.LogInformation(message);
        }

        public void Error(string message)
        {
            _logger.LogError(message);
        }
    }
}
