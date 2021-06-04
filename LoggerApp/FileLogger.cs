using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanımı
{
    class FileLogger : ILoggerService
    {
        public void Logged()
        {
            Console.WriteLine("logged to file succesfully!");
        }
    }
}
