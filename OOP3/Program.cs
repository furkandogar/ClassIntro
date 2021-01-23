using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            //ihtiyacKrediManager1.Hesapla();

            //TasitKrediManager tasitKrediManager1 = new TasitKrediManager();
            //tasitKrediManager1.Hesapla();

            //KonutKrediManager konutKrediManager1 = new KonutKrediManager();
            //konutKrediManager1.Hesapla();

            //IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            //ihtiyacKrediManager2.Hesapla();

            //IKrediManager tasitKrediManager2 = new TasitKrediManager();
            //tasitKrediManager2.Hesapla();

            //IKrediManager konutKrediManager2 = new KonutKrediManager();
            //konutKrediManager2.Hesapla();

            IKrediManager ihtiyacKrediManager3 = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager3 = new TasitKrediManager();
            IKrediManager konutKrediManager3 = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager3, new DatabaseLoggerService());

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager2 = new BasvuruManager();
            basvuruManager2.BasvuruYap(konutKrediManager3, databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager3, tasitKrediManager3 };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            // Interface kullanımının tam amacı budur.
            BasvuruManager basvuruManager3 = new BasvuruManager();
            basvuruManager3.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService());
            // Interface kullanımının tam amacı budur.

            List<ILoggerService> loglar = new List<ILoggerService>() { fileLoggerService, new SmsLoggerService() };
            new BasvuruManager().BasvuruYapYeni(new EsnafKrediManager(), loglar);

            // Ya da direkt
            new BasvuruManager().BasvuruYapYeni(new IhtiyacKrediManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });
        }
    }
}
