using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        /*TODO: 
        Decidir tipo de Valor
        public int Valor { get; set; }
        public String Valor { get; set; }
        */
        private int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Disco(int valor)
        {
            Valor = valor;
        }

    }
}
