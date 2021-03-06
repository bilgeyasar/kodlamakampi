﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtıyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(),
            new FileLoggerService()};
            BasvuruManager basvuruManager = new BasvuruManager();
           basvuruManager.BasvuruYap(new EsnafKredisiManager(), 
               new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() } );
            
            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager,tasitKrediManager
            };

           // basvuruManager.KrediOnBilgilendirmeYap(krediler);



            Console.ReadLine();

        }
    }
}
