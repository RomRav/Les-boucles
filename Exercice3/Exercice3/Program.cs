using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int saisieInInt;
            bool again = true;
            bool inputIsWrong = true;
            string inputContinueChoice;
            string saisie;
            while (again)
            {
                inputIsWrong = true;
                Console.WriteLine("Saisissez un nombre à additionner:");
                saisie = Console.ReadLine();
                if (int.TryParse(saisie,out saisieInInt))
                {
                    result += saisieInInt;
                    Console.WriteLine($"resultat: {result}");
                    while (inputIsWrong)
                    {
                        Console.WriteLine("Voulez-vous ajouter un nombre(oui/non):");
                        inputContinueChoice = Console.ReadLine().ToLower().Trim();
                        if (inputContinueChoice == "non")
                        {
                            again = false;
                            inputIsWrong = false;
                        }
                        else if(inputContinueChoice == "oui") 
                        {
                            inputIsWrong = false;
                        }
                        else
                        {
                            Console.WriteLine("Saisie incorrect");
                        }
                    }
                    
                }
                else
                {
                    Console.Write("La saisie n'est pas un nombre.");
                }               
                
                
            }
            
        }
    }
}
