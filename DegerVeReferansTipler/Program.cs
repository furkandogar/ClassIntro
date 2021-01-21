using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            // 30
            // değer atanması değer tiplerde stack'te gerçekleşir.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
            // 999
            // referans tipler için değer atanması heap'te olur.
            // "new" ile heap'te adres tutmayı sağlar.
            // sayilar1 = sayilar2 satırı ile heap'te sayilar1 için gösterilen adres
            // değiştirilir, önceden { 10, 20, 30 } arrayinin tutulduğu adres sayilar1'e
            // hedef olarak gösteriliyordu, artık { 100, 200, 300 } arrayinin tutulduğu
            // adres sayilar1'e hedef olarak gösterilir. Bu yüzden, sayilar1 = sayilar2
            // satırından sonra bile sayilar2'ye hedef olarak gösterilen adresteki arrayde
            // bir değişim yapılırsa bu dğişim sayilar1'e de yansır.
        }
    }
}
