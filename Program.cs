using InyeccionDependeciasConsole.Abstractions;
using InyeccionDependeciasConsole.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace InyeccionDependeciasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            // services.AddSingleton<IGreeter, Greeter>();
            services.AddTransient<IGreeter, Greeter>();

            var servicesProvider = services.BuildServiceProvider();

            var greeter1 = servicesProvider.GetService<IGreeter>();
            var greeter2 = servicesProvider.GetService<IGreeter>();
            Console.WriteLine(greeter1.Salute("juan"));
            Console.WriteLine(greeter1.Salute("pedro"));
            PrintHash(greeter1);
            PrintHash(greeter2);
            Console.ReadKey();

        }

        static void PrintHash(object obj)
        {
            Console.WriteLine(obj.GetHashCode().ToString());
        }
    }
}
