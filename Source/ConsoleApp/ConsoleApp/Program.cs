using ConsoleApp;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private readonly HelloWorldService _helloWorldService;

        public Program(HelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }


        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IHelloWorldService, HelloWorldService>()
                .BuildServiceProvider();


            var _helloWorldService = serviceProvider.GetService<IHelloWorldService>();

            var text = _helloWorldService.GetHelloWorld();

            Console.WriteLine(text);
        }
    }
}