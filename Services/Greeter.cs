using InyeccionDependeciasConsole.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDependeciasConsole.Services
{
    public class Greeter : IGreeter
    {
        public Guid Id { get; private set; }

        public Greeter()
        {
            Id = Guid.NewGuid();
            Console.WriteLine($"Created {nameof(Greeter)} instance with id {Id.ToString()}");
        }

        public string Salute(string name)
        {
            return $"Hola {name} - Eres un programador de .Net";
        }
    }
}
