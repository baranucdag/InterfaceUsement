using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanımı
{
    class DatabaseLogger : ILoggerService
    {
        public void Logged()
        {
            Console.WriteLine("Logged to database");
        }
    }
}
