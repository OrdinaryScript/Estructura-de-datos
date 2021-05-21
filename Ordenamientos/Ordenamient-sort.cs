using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ordenamiento_sort
{
    class Program
    {
        private int [] numeros;
        private IList<IList<int>> digitos = new List<IList<int>>(); 
        private int tmax = 0;
        public Program (){
            for (int x = 0; x < 10; x++){
                digitos.Add(new List<int>());
            } 
            numeros=new int[39];
            Console.WriteLine("=-=-=-=-= Ingresando valores =-=-=-=-=");
            Console.WriteLine("");   
            for (int c = 0; c < numeros.Length; c++){            
                Console.WriteLine("Ingrese el numero de control del alumno #{0}.", c + 1);
                numeros[c] = int.Parse(Console.ReadLine());
                if(tmax<numeros[c].ToString().Length){
                    tmax = numeros[c].ToString().Length;
                }
            }               
        }
        public void SortRaiz(){
            for (int i = 0; i < tmax; i++){
                for (int j = 0; j < numeros.Length; j++){
                    int digito = (int)((numeros[j] % Math.Pow(10,i+1))/Math.Pow(10,i));
                    digitos[digito].Add(numeros[j]);
                }
                int indice = 0;
                for (int y = 0; y < digitos.Count; y++){
                    IList<int> seldigito = digitos[y];
                    for(int I=0; I < seldigito.Count; I++){
                        numeros[indice++] = seldigito[I];
                    }
                }
                LimpiarDigitos();
            }
            MostrarOrdenados();
        }
        private void LimpiarDigitos(){
            for(int k = 0; k < digitos.Count; k++){
                digitos[k].Clear();
            }
        }
        public void MostrarOrdenados(){
            Console.WriteLine("=-=-=-=-= Mostrando datos en forma ascendente =-=-=-=-=");
            for(int i = 0; i < numeros.Length; i++){
                Console.WriteLine(numeros[i]);
            }
        }
        static void Main(string[] args)
        {
            new Program().SortRaiz();
            Console.ReadLine();
        }
    }
}
