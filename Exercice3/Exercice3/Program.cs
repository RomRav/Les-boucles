using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            bool again = true;
            string inputContinueChoice;
            while (again)
            {
                Console.WriteLine("Saisissez un nombre à additionner:");
                result += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"resultat: {result}");
                Console.WriteLine("Voulez-vous ajouter un nombre(oui/non):");
                inputContinueChoice = Console.ReadLine().ToLower();
                if (inputContinueChoice == "non")
                {
                    again = false;
                }
            }
            
        }
    }
}
