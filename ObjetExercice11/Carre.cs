using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetExercice11
{
    public class Carre
    {
        public Carre(int departX, int departY, int hauteur, int largeur, char symbole, char arrierePlan)
        {
            Console.SetCursorPosition(departX, departY);
            int premiereLigne = 0;
            int derniereLigne = premiereLigne + hauteur - 1;
            //boucle pour les lignes
            for (int ligneActuelle = 0; ligneActuelle < hauteur; ligneActuelle++)
            {
                // premiere et dernière ligne
                if (ligneActuelle == 0 || ligneActuelle == derniereLigne)
                {
                    for (int colonneActuelle = 0; colonneActuelle < largeur; colonneActuelle++)
                    {
                        Console.Write(symbole);
                    }
                }
                // autres lignes
                else
                {
                    // 1 caractère
                    Console.Write(symbole);
                    // des espaces
                    for (int colonneActuelle = 0; colonneActuelle < largeur-2; colonneActuelle++)
                    {
                         Console.Write(arrierePlan);
                    }
                    // 1 caractère
                    Console.Write(symbole);
                }
                // Remettre le chariot à la ligne suivant
                
                Console.SetCursorPosition(departX, departY+ligneActuelle+1);
            }

        }
    }
}
