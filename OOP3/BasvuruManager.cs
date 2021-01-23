using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method Injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            // Başvuran Bilgilerini Değerlendirme
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void BasvuruYapYeni(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            // Başvuran Bilgilerini Değerlendirme
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
