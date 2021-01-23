using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Bu interface'in içindeki methodlar her çeşit kredide kullanılacak methodlardır.
    // Eğer ki bir sınıf bu interface'i kullanırsa bu interface'deki methodları kullanmak zorundadır.

    // Interface'ler de o interface'i implemente eden class'ın referans numarasını tutabilir.

    // Interface'leri, birbirinin alternatifi olan; ama kod içerikleri farklı olan durumlar için kullanırız.

    // Interface içinde sadece imza method'ları olur, içi dolu olamaz.
    interface IKrediManager
    {
        void Hesapla();
        void BiSeyYap();
    }
}
