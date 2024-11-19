using DIActionConsole.service;
using Microsoft.Extensions.DependencyInjection;

namespace DIActionConsole
{
    public class Program
    {
        public static void Main()
        {
            // 註冊服務
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IRenovationTask, PaintWallsTask>()
                .AddSingleton<IRenovationTask, BuildFurnitureTask>()
                .AddSingleton<IRenovationTask, InstallElectricalWiringTask>()
                .AddSingleton<Startup>()
                .BuildServiceProvider();

            // 透過 DI 執行 Startup
            var startup = serviceProvider.GetRequiredService<Startup>();
            startup.Run();

            // 使用注入的服務
            //foreach (var service in serviceProvider.GetServices<IRenovationTask>())
            //{
            //    service.Execute(service.Description);
            //}

            Console.ReadLine();
        }
    }
}
