using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool isFound = false;
            int inputInInt;
			//Utilisation de la méthode Next de l'object Random pour récupérer un nombre au hasard entre 1 et 50.
            int randNumber = rand.Next(1, 51);
            int tryCount = 1;         
            string inputToString;
			//Boucle tant que l'utilisateur veux additionner un autre nombre.
            while (!isFound)
            {             
                Console.WriteLine("Devinez le nombre (entre 1 et 50):");
                Console.WriteLine("Saisissez un nombre:");
                inputToString = Console.ReadLine();
				//Verifie que la saisie soit convertible et la convertie en entier.
                if (int.TryParse(inputToString,out inputInInt))
                {
					//Verifie et compare la saisie par rapport au nombre mystére et affiche un message en fonction 
                    if (randNumber == inputInInt)
                    {
                        Console.WriteLine("Bravo vous avez trouvé !");
                    isFound = true;
                    }
                    else if (inputInInt < randNumber)
                    {
                        Console.WriteLine("C’est plus grand");
                    }
                    else
                    {
                        Console.WriteLine(" C’est plus petit");
                    }
                }
                else
                {
                    Console.WriteLine("La saisie n'est pas un nombre");
                }
                Console.WriteLine($"Tentative : {tryCount++}");
            }
        }
    }
}
