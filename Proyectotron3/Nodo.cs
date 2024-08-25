using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectotron3
{
    internal class Nodo
    {
        public int Valor;
        public Nodo Arriba;
        public Nodo Abajo;
        public Nodo Izquierda;
        public Nodo Derecha;

        public Nodo(int value)
        { 
            this.Valor = value;
            this.Arriba = null;
            this.Abajo = null;
            this.Izquierda = null;
            this.Derecha = null;
        }
        


    }
}
