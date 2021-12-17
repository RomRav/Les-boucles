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
			//Boucle tant que l'utilisateur veux additionner un autre nombre.
            while (again)
            {
                inputIsWrong = true;
                Console.WriteLine("Saisissez un nombre à additionner:");
                saisie = Console.ReadLine();
				//verifie que la saisie soit convertible et convertie en entier la donnée saisie.
                if (int.TryParse(saisie,out saisieInInt))
                {
					//Ajout du nombre saisie à la variable
                    result += saisieInInt;
                    Console.WriteLine($"resultat: {result}");
					//Boucle tant que l'utilisateur ne saisie pas oui ou non.
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
