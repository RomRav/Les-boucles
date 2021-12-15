using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool again = true;
            int inputInInt;
            int randNumber = rand.Next(1, 50);
            int counter = 1;
            bool verifInput = true;
            string inputToString;
            while (again)
            {
                while (verifInput)
                {
                    Console.WriteLine("Devinez le nombre (entre 1 et 50):");
                    Console.WriteLine("Saisissez un nombre:");
                    inputToString = Console.ReadLine();
                    if (int.TryParse(inputToString,out inputInInt))
                    {
                        if (randNumber == inputInInt)
                        {
                            Console.WriteLine($"Bravo vous avez trouvé !");
                            again = false;
                            verifInput = false;
                        }
                        else if (inputInInt < randNumber)
                        {
                            Console.WriteLine("C’est plus grand");
                        }
                        else
                        {
                            Console.WriteLine(" C’est plus petit");
                        }
                        Console.WriteLine($"Tentative : {counter++}");
                    }
                    else
                    {
                        Console.WriteLine("La saisie n'est pas un nombre");
                    }
                    
                    
                }              
            }
        }
    }
}
