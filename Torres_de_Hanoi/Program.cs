using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduix el número de discos: ");
            int nDiscos = Int32.Parse(Console.ReadLine());
            
            //Crear llista de discos 
            List<Disco> l = new List<Disco>();

            for (int i = nDiscos; i > 0; i--)
            {
                Console.WriteLine("Creant disc: " + i);
                l.Add(new Disco(i));
            }
            Console.WriteLine("\n");

            //**********************************************
            //Crear objectes Pila 
            Pila ini = new Pila("Ini");
            //Introduim els discos a la pila Ini
            ini.Elementos = l;

            Pila aux = new Pila("Aux");

            Pila fin = new Pila("Fin");


            //**********************************************
            //Execució dels algoritmes
            Hanoi h = new Hanoi();

            //Algortime iteratiu
            Console.WriteLine("Execució de l'algoritme iteratiu\n");
            int moviments = h.iterativo(nDiscos, ini, fin, aux);
            Console.WriteLine("Moviments: " + moviments + "\n");//*/


            //**********************************************

            /*int factorial(int n)
            {
                if(n == 0)
                {
                    return 1;
                }
                return factorial(n - 1) * n;
            }

            int res = factorial(nDiscos);
            Console.WriteLine("Resultat factorial: " + res);*/

            /*//Algoritme recursiu
            Console.WriteLine("Execució de l'algoritme recursiu\n");
            int moviments2 = h.algoritmeRecursiu(nDiscos, ini, fin, aux);
            Console.WriteLine("Moviments: " + moviments2 + "\n");//*/

            //**********************************************

            //**********************************************

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
