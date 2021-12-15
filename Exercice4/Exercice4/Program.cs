using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool again = true;
            int inputNumber;
            int attempt;
            int randNumber = rand.Next(1, 50);
            int counter = 1;
            while (again)
            {              
                Console.WriteLine("Devinez le nombre (entre 1 et 50):");
                Console.WriteLine("Saisissez un nombre:");
                inputNumber = Convert.ToInt32(Console.ReadLine());
                if (randNumber==inputNumber)
                {
                    Console.WriteLine($"Bravo vous avez trouvé !");
                    again = false;
                }else if (inputNumber < randNumber)
                {
                    Console.WriteLine("C’est plus grand");
                }
                else
                {
                    Console.WriteLine(" C’est plus petit");
                }
                Console.WriteLine($"Tentative : {counter++}");
            }
            

        }
    }
}
