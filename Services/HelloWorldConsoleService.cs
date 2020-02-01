namespace Heloworld.Services{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Hosting;
    public class HelloWorldConsoleService : BackgroundService{
        IHelloWorldService _helloWorldService;
        public HelloWorldConsoleService(IHelloWorldService helloWorldService){
            _helloWorldService = helloWorldService;
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken){
            Console.WriteLine(_helloWorldService.HelloWroldString);
            return Task.CompletedTask;
        }
    }
}