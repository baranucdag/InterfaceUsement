using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanımı
{
    class LogManager 
    {                       //burada yapılacak olan kayıt işleminin yönetimi yapılacaktır (operasyon class'ı).
        public void logManagement(ILoggerService loggerService)
        {
            loggerService.Logged();
        }
    }
}
