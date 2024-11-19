using DIActionConsole.service;
using Microsoft.Extensions.DependencyInjection;

namespace DIActionConsole
{
    internal class Startup
    {
        private readonly IServiceProvider _serviceProvider;

        public Startup(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Run()
        {
            // 使用注入的服務
            var services = _serviceProvider.GetServices<IRenovationTask>();
            foreach (var service in services)
            {
                service.Execute(service.Description);
            }
        }
    }
}
