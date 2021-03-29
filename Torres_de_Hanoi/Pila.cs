using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        private int size = 0;
        private int top = 0;
        private string nom = "";
        private List<Disco> elementos = new List<Disco>();

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        public int Top
        {
            get { return top; }
            set { top = value; }
        }

        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        public List<Disco> Elementos
        {
            get { return elementos; }
            set
            {
                elementos = value;
                Size = value.Count;
                Top = value[value.Count - 1].Valor;
            }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        /* TODO: Implementar métodos */
        public Pila() { }


        public Pila(string nom)
        {
            Nom = nom;
        }

        //Introduir disc en la List<Disco>, i indicar el Top
        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = Elementos[Elementos.Count - 1].Valor;
            Size = Elementos.Count;
        }

        //Eliminar disc de la List<Disco>, i indicar el següent Top
        public Disco pop()
        {
            Disco d = Elementos[Elementos.Count-1];
            Elementos.RemoveAt(Elementos.Count - 1);
            Size = Elementos.Count;
            if (this.isEmpty()) Top = 0;
            else Top = Elementos[Elementos.Count - 1].Valor;

            return d;
        }


        //Comprovar el nº elements en la llista
        public bool isEmpty()
        {
            if (Size == 0)
            {
                return true;
            }
            return false;
        }

    }
}
