using System;

namespace InterfaceKullanımı
{
    class Program
    {
        public static FileLogger ILoggerService { get; private set; }

        static void Main(string[] args)
        {
            ILoggerService databaseLogg = new DatabaseLogger();

            LogManager logManager = new LogManager();
            logManager.logManagement(databaseLogg);


        }
    }
}
