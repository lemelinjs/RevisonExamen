using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetExercice11
{
    class Program
    {
        static void Main(string[] args)
        {
            Formes dessin = new ObjetExercice11.Formes();
            Carre carre = new Carre(10,10,10,10,'*', '.');
            Console.ReadKey();
        }
    }
}
