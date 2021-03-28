using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {

            if (a.isEmpty() || (!b.isEmpty() && (b.Top < a.Top)))
            {
                Console.WriteLine("Moure disc " + b.Top + " de Torre " + b.Nom + " a Torre " + a.Nom);
                Disco d = new Disco(b.Top);
                a.push(d);
                b.pop();
            }

            else if (b.isEmpty() || (!a.isEmpty() && (a.Top < b.Top)))
            {
                Console.WriteLine("Moure disc " + a.Top + " de Torre " + a.Nom + " a Torre " + b.Nom);
                Disco d = new Disco(a.Top);
                b.push(d);
                a.pop();
            }

        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;

            if (n % 2 != 0)
            {
                do
                {
                    m++;

                    if (m == 1 || m % 3 == 1)
                    {
                        mover_disco(ini, fin);
                    }
                    else if (m == 2 || m % 3 == 2)
                    {
                        mover_disco(ini, aux);
                    }
                    else if (m == 3 || m % 3 == 0)
                    {
                        mover_disco(aux, fin);
                    }

                    Console.WriteLine("Torre Ini: ");
                    print_Discos(ini);

                    Console.WriteLine("Torre Aux: ");
                    print_Discos(aux);

                    Console.WriteLine("Torre Fin: ");
                    print_Discos(fin);

                    Console.WriteLine("\n");

                } while (fin.Size != n);
            }
            else
            {
                do
                {
                    m++;
                    if (m == 1 || m % 3 == 1)
                    {
                        mover_disco(ini, aux);
                    }
                    else if (m == 2 || m % 3 == 2)
                    {
                        mover_disco(ini, fin);
                    }
                    else if (m == 3 || m % 3 == 0)
                    {
                        mover_disco(aux, fin);
                    }

                    Console.WriteLine("Torre Ini: ");
                    print_Discos(ini);

                    Console.WriteLine("Torre Aux: ");
                    print_Discos(aux);

                    Console.WriteLine("Torre Fin: ");
                    print_Discos(fin);

                    Console.WriteLine("\n");

                } while (fin.Size != n);
            }
            return m;
        }

        public int algoritmeRecursiu(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;

            if (n == 1)
            {
                m++;
                mover_disco(ini, fin);

                /*//Imprimir per consola
                Console.WriteLine("Torre Ini: ");
                print_Discos(ini);

                Console.WriteLine("Torre Aux: ");
                print_Discos(aux);

                Console.WriteLine("Torre Fin: ");
                print_Discos(fin);

                Console.WriteLine("\n");**/
            }
            else
            {
                m += algoritmeRecursiu(n - 1, ini, aux, fin);
                m++;
                mover_disco(ini, fin);

                /*//Imprimir per consola
                Console.WriteLine("Torre Ini: ");
                print_Discos(ini);

                Console.WriteLine("Torre Aux: ");
                print_Discos(aux);

                Console.WriteLine("Torre Fin: ");
                print_Discos(fin);

                Console.WriteLine("\n");*/

                m += algoritmeRecursiu(n - 1, aux, fin, ini);
            }

            return m;
        }

        public void print_Discos(Pila a)
        {
            if (a.Size == 0)
            {
                Console.WriteLine(0);
                return;
            }

            foreach (Disco d in a.Elementos)
            {
                Console.WriteLine(d.Valor);
            }

        }

    }
}
