namespace Heloworld{
    using Heloworld.Services;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    class Program{
        static void Main(string[] args){
            new HostBuilder()
                        .ConfigureServices(services => {
                            services.AddScoped(typeof(IHelloWorldService), typeof(HeloWorldService));
                            services.AddHostedService<HelloWorldConsoleService>();
                        })
                        .Build().Run();
        }
    }
}
