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
            int metode = 0;


            //Preguntar el mètode de resolució escollit
            while(metode != 1 && metode != 2){
                Console.WriteLine("Escollix mètode:\n ");
                Console.WriteLine("1. Mètode iteratiu\n ");
                Console.WriteLine("2. Mètode recursiu\n");
              
                metode = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\n ");

                if(metode != 1 && metode != 2){
                    Console.WriteLine("Introdueix el nº del mètode escollit\n ");
                }

            }
            
            //Números de discos escollits
            Console.WriteLine("Introduix el número de discos: ");
            int nDiscos = Int32.Parse(Console.ReadLine());

            if(nDiscos <= 0){
                Console.WriteLine("Impossible jugar. Número de discos no pot ser inferior o igual.\n");
                Console.ReadKey();
            }else{
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

                if(metode == 1){
                    //Algortime iteratiu
                    Console.WriteLine("Execució de l'algoritme iteratiu\n");
                    int moviments = h.iterativo(nDiscos, ini, fin, aux);
                    Console.WriteLine("Moviments: " + moviments + "\n");//*/

                }else if(metode == 2){
                    //Algoritme recursiu
                    Console.WriteLine("Execució de l'algoritme recursiu\n");
                    int moviments2 = h.algoritmeRecursiu(nDiscos, ini, fin, aux);
                    Console.WriteLine("Moviments: " + moviments2 + "\n");//*/
                }
            

                //**********************************************

                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
            
            
        }
    }
}
