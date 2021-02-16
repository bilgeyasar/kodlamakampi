using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //SOLID'in Open source principle: Sisteme yeni eklendiğinde öevcut olan bozulmaz
    class EsnafKredisiManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }
    }

    
}
