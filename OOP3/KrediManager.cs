using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interface'i kullanırsa biri o kullanımda void Hesapla() olmak zorunda
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }

    //Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan
    //durumlar için kullanırız.
}
