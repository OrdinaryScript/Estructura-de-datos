using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shell_ascendente
{
    class Program
    {
        private int[] empleados;
        public void Ingresar(){
            empleados = new int [15];
            for (int f = 0; f< empleados.Length; f++){
                Console.WriteLine("Ingresa el elemento " + (f+1) + ": ");
                empleados[f] = Convert.ToInt16(Console.ReadLine());
            }
        }
        public void MetodoShell(){
            int salto, flag, aux, contador = 0;
            salto = empleados.Length/2;
            while (salto > 0){
                flag = 1;
                while (flag != 0){
                    flag = 0;
                    contador = 1;
                    while(contador <= (empleados.Length - salto)){
                        if (empleados[contador - 1] > empleados[(contador - 1) + salto]){
                            aux = empleados[(contador - 1) + salto];
                            empleados[(contador - 1) + salto] = empleados[contador - 1];
                            empleados[(contador - 1)] = aux;
                            flag = 1;
                        }
                        contador++;
                    }
                }
                salto = salto/2;
            }
        }
        public void Imprimir(){
            for (int f = 0; f < empleados.Length; f++){
                Console.Write(empleados[f] + "  ");
            }
        }
        static void Main(string[] args)
        {
            Program ob_os = new Program();
            Console.Title = "Ordenamiento ascendente por Shell";
            Console.WriteLine("=-=-=-=-= Ingresando valores =-=-=-=-=");
            Console.WriteLine("");
            ob_os.Ingresar();
            Console.WriteLine("");
            Console.WriteLine("=-=-=-=-= Valores ingresados =-=-=-=-=");
            Console.WriteLine("");
            ob_os.Imprimir();
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para mostrar de forma ascendente.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("=-=-=-=-= Mostrando ordenados en forma ascendente =-=-=-=-=");
            Console.WriteLine("");
            ob_os.MetodoShell();
            ob_os.Imprimir();
        }
    }
}
