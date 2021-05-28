using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Campos Guillen Eduardo
*   Estructuras de datos
*   Ing. Sistemas Computacionales
*/
namespace intercalacion_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando variables, 
            int f, i, izq, der, N, mitad;
            float[] sueldos = new float[17];
            float aux, sueldo;
            // Declarando el tamaño del vector
            N = sueldos.Length;
            // Titulo para ingresar sueldos
            Console.WriteLine("=-=-=-=-= Insertando sueldos =-=-=-=-=");
            Console.WriteLine("");
            // Ingresando salarios
            for (i = 0; i < 17; i++){
                Console.WriteLine("Ingrese el sueldo #{0}.", (i + 1));
                sueldo = Convert.ToSingle(Console.ReadLine());
                sueldos[i] = sueldo;
            }
            Console.Clear();
            // Mostrando sueldos
            Console.WriteLine("=-=-=-=-= Mostrando sueldos desordenados =-=-=-=-=");
            Console.WriteLine("");
            for (i = 0; i < 17; i++){
                Console.WriteLine("{0}.- ${1} ", (i + 1), sueldos[i]);
            }
            Console.WriteLine("Presione cualquier tecla para mostrar ordenado.");
            Console.ReadKey();
            Console.Clear();
            // Procedimiento de intercalación
            for (i = 1; i < N; i++){
                aux = sueldos[i];
                izq = 0;
                der = i - 1;
                while (izq <= der){
                    mitad = (izq + der) / 2;
                    if (aux <= sueldos[mitad])
                        der = mitad - 1;
                    else
                        izq = mitad + 1;
                }
                f = i - 1;
                while (f >= izq){
                    sueldos[f + 1] = sueldos[f]; 
                    f--;
                }
                sueldos[izq] = aux;
            }
            // Mostrando sueldos
            Console.WriteLine("=-=-=-=-= Mostrando sueldos ordenados =-=-=-=-=");
            Console.WriteLine("");
            for (i = 0; i < 17; i++){
                Console.WriteLine("{0}.- ${1} ", (i + 1), sueldos[i]);
            }
            Console.WriteLine("Presione cualquier tecla para terminar.");
            Console.ReadKey();
        }
    }
}
