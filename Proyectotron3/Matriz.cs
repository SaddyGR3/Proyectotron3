using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proyectotron3
{
    internal class Matriz
    {
        private Nodo head;
        private int filas;
        private int columnas;

        public Matriz(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            this.head = null;

            IniciarMatriz();
        }

        public void IniciarMatriz()
        {
            Nodo[,] matriz = new Nodo[filas, columnas]; //inicializa una matriz 2D de objetos tipo Nodo. De tamaño filasxcolumnas.
                                                        //Es un Arreglo que almacena todos los nodos de la matriz.
            for (int i = 0; i < filas; i++) //bucle for que itera sobre las filas.
            {
                for (int j = 0; j < columnas; j++)//bucle para iterar columnas dentro de cada fila.
                {
                    matriz[i, j] = new Nodo(0); //Se crea una nueva instancia de nodo con un valor inicial de 0 y se le asigna la posicion i,j de la matriz.

                    if (i > 0)//si el nodo no esta en la primera fila
                        matriz[i, j].Arriba = matriz[i - 1, j]; //Entonces tiene un Nodo arriba,al que se le asigna una referencia desde el actual al de arriba.

                    if (j > 0)//si el nodo no esta en la primera columna
                        matriz[i, j].Izquierda = matriz[i, j - 1]; //significa que tiene un nodo a la izquierda,al que le asigna una referencia desde el actual al de la izquierda.

                    if (i < filas - 1)//Si el nodo no esta en la ultima fila
                        matriz[i, j].Abajo = matriz[i + 1, j];//Significa que tiene un nodo debajo,le asigna una referencia.

                    if (j < columnas - 1)//Si el nodo no esta en la ultima columna
                        matriz[i, j].Derecha = matriz[i, j + 1];//Significa que tiene un nodo a la derecha.le asigna referencia.
                }
            }
            this.head = matriz[0, 0];//este seria el primer nodo,la cabeza de la matriz.
        }
        public Nodo GetNode(int fila, int columna) //metodo que toma dos parametros,fila y columna y retorna un objeto nodo.
        {
            if (fila < 0 || columna < 0 || fila >= filas || columna >= columnas) //Verifica que las coordenadas dadas esten dentro de la matriz.
            {
                throw new ArgumentOutOfRangeException(); //esto es un error y ya.
            }

            Nodo current = head; //se inicia esta variable current que es el primer nodo de la matriz en la pos [0,0]
            for (int i = 0; i < fila; i++) //itera la matriz hacia abajo.
            {
                current = current.Abajo; //en cada iteracion mueve el nodo actual en la matriz hacia abajo utilizando la referencia respectiva.
            }
            for (int j = 0; j < columna; j++) //al llegar a la fila correcta,recorre la matriz hacia la derecha 
            {
                current = current.Derecha; //en cada iteracion mueve el nodo actual utilizando la referencia derecha.
            }

            return current; //devuelve el nodo que se encuentra en la pos de la entrada.
        }
        public void SetValue(int fila, int columna, int valor) //metodo que toma 3 parametros fila,columna,valor y no retorna nada(void)
        {
            Nodo nodo = GetNode(fila, columna); //llama al metodo GetNode para obtener el nodo que se encuentra en la posicion(Fila,columna) en la matriz.
            nodo.Valor = valor; //asigna el valor de entrada a el nodo obtenido.
        }

        public int GetValue(int fila, int columna) //metodo que retorna el valor almacenado en algun nodo especifico de la matriz.
        {
            return GetNode(fila, columna).Valor;
        }
    }
}
