using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "bilge",
                LastName = "yasar",
                IdentityNumber = 1221
            });
            Console.ReadLine();
        }
    }
}
