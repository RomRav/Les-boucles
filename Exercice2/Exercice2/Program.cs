using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
			//Affichage d'une chaîne de caractére contenant le nombre d'itération de la chaîne.
            
            for(int messageNumber = 1; messageNumber <= 10; messageNumber++)
            {
                Console.WriteLine($"Bonjour, je suis le message n°{messageNumber}.");              
            }
        }
    }
}
