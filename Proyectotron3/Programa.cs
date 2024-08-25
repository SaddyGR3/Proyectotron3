using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectotron3
{
    internal class Programa
    {
        static void Main()
        {
            Matriz matrix = new Matriz(20, 20);

            matrix.SetValue(0, 0, 1);
            matrix.SetValue(1, 1, 2);
            matrix.SetValue(2, 2, 3);

            Console.WriteLine(matrix.GetValue(0, 0)); // 1
            Console.WriteLine(matrix.GetValue(1, 1)); // 2
            Console.WriteLine(matrix.GetValue(2, 2)); // 3
        }
    }
}
