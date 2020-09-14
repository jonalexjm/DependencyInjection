using InyeccionDependeciasConsole.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDependeciasConsole.Services
{
    public class UserGreeter : IUserGreeter
    {
        private readonly string _user;

        public UserGreeter(string user)
        {
            _user = user;
            Console.WriteLine($"New {nameof(UserGreeter)} instance with user: {_user}");
        }
        public string Salute()
        {
            return $"Hola usuario {_user}";
        }
    }
}
