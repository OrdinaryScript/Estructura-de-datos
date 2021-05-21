using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burbujas_y_sus_variantes
{
    class Program
    {
        public int[] vector; 
        public string[] vector2, vector3;

        // Ingresar valores
            public void IngresarValoresBM()
            {
                vector = new int[18];
                
                for (int f = 0; f < vector.Length; f++)
                {

                    Console.WriteLine("Ingrese la calificacion " + (f + 1) + ": ");
                    vector[f] = int.Parse(Console.ReadLine());

                }
            }
            public void IngresarValoresBS()
            {
                vector2 = new string[10];
                for(int f = 0; f < vector2.Length; f++)
                {
                    Console.WriteLine("Ingrese el nombre " + (f + 1) + ": ");
                    vector2[f] = Console.ReadLine();
                }
            }
            public void IngresarValoresBO()
            {
                vector3 = new string[12];
                for(int f = 0; f < vector3.Length; f++)
                {
                    Console.WriteLine("Ingrese el nombre " + (f + 1) + ": ");
                    vector3[f] = Console.ReadLine();
                }
            }
            // Metodos
            public void MetodoBurbujaSimple()
            {
             for(int i = 0; i < vector2.Length - 1; i++)
                {
                    for (int j = i + 1; j < vector2.Length; j++)
                    {
                        if (vector2[i].CompareTo(vector2[j]) > 0)
                        {
                            string DT;
                            DT = vector2[i];
                            vector2[i] = vector2[j];
                            vector2[j] = DT;
                        }
                    }
                }
                Console.WriteLine("Vector ordenados en forma ascendente de la burbuja mejorada");
                for (int f = 0; f < vector2.Length; f++)
                {
                    Console.Write(vector2[f] + " ");
                }
            }
        public void MetodoBurbujaMejorada()
        {
            int bandera = 1;
            int aux = 0;
            int N = vector.Length;

            for (int p = 0; p < vector.Length -1 && bandera == 1; p++)
            {
                bandera = 0;
                for (int j=0; j < N-p -1;j++)          
                {
                if (vector[j] < vector[j + 1])
                {
                        bandera = 1;
                        aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                }
            }
        }
            Console.WriteLine("Vector ordenados en forma descendente de la burbuja mejorada");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + " ");
            }
        }
        public void MetodoBurbujaOptimizada()
        {
            int i = 1;
            string Ordenado = "Si"; 
            string aux;
            do
            {
                i++;
                for (int j = 0; j < vector3.Length - 1; j++)
                {
                        
                    if (string.Compare(vector3[j], vector3[j + 1]) < 0)
                    {
                        Ordenado = "No";
                        aux = vector3[j];
                        vector3[j] = vector3[j + 1];
                        vector3[j + 1] = aux;
                    }
                }
                Console.WriteLine("Vector ordenados en forma ascendente de la burbuja mejorada");
                for (int f = 0; f < vector3.Length; f++)
                {
                    Console.Write(vector3[f] + " ");
                }
            } while (i < vector3.Length && Ordenado != "Si");
        }

        // public void MenuMostrar()
        // { 
        //     Program c = new Program();
        //     char respuesta;
        //     int menu2 = 1;
        //     do
        //     {
        //         Console.WriteLine("=-=-=-=-= Mostrar ordenamiento=-=-=-=-= \n"+
		// 					"Qué lista desea mostrar? \n" +
		// 					"\t\n" +
		// 					"[1] Mostrar ordenamiento de burbuja simple\n" +
		// 					"[2] Mostrar ordenamiento de burbuja mejorada\n" +
		// 					"[3] Mostrar ordenamiento de burbuja optimizada\n");
		// 		Console.WriteLine("");
		// 		Console.WriteLine("[4] Volver al menú principal");
        //         respuesta = Console.ReadKey().KeyChar;
        //         switch (respuesta)
        //         {
        //             case '1':
        //                 c.MetodoBurbujaSimple();
        //             break;
        //             case '2':
        //                 c.MetodoBurbujaMejorada();
        //             break;
        //             case '3':
        //                 c.MetodoBurbujaOptimizada();
        //             break;
        //             case '4':
        //                 menu2 = 0;
        //             break; 
        //         }
        //     }while(menu2 != 0);

        // }
        static void Main(string[] args)
        {
            Program b = new Program();
            char opc, respuesta;
            int menu = 1;  
            int menu2 = 1;       
            do
            {
				Console.WriteLine("=-=-=-=-= Menú =-=-=-=-= \n" +
							"¿Qué desea hacer? \n" +
							"\t\n" +
							"[1] Sorteo de burbuja simple\n" +
							"[2] Sorteo de burbuja mejorada\n" +
							"[3] Sorteo de burbuja optimizada\n" +
                            "[4] Mostrar ordenamiento\n");
				Console.WriteLine("");
				Console.WriteLine("[5] Salir");
                opc = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (opc)
                {
                    case '1':
                        Console.WriteLine("=-=-=-=-= Metodo burbuja simple =-=-=-=-=\n");
                        b.IngresarValoresBS();
                        Console.WriteLine("");
                        b.MetodoBurbujaSimple();
                        Console.WriteLine("");
                        Console.WriteLine("Presiona cualquier tecla para volver al menú");
                        Console.ReadKey();
                    break;
                    case '2':
                        Console.WriteLine("=-=-=-=-= Metodo burbuja mejorada =-=-=-=-=\n");
                        b.IngresarValoresBM();
                        Console.WriteLine("");                        
                        b.MetodoBurbujaMejorada();
                        Console.WriteLine("");
                        Console.WriteLine("Presiona cualquier tecla para volver al menú");
                        Console.ReadKey();
                    break;
                    case '3':
                        Console.WriteLine("=-=-=-=-= Metodo burbuja optimizada =-=-=-=-=\n");
                        b.IngresarValoresBO();
                        Console.WriteLine("");                        
                        b.MetodoBurbujaOptimizada();
                        Console.WriteLine("");
                        Console.WriteLine("Presiona cualquier tecla para volver al menú");
                        Console.ReadKey();
                    break;
                    case '4':
                    do
                    {
                        Console.WriteLine("=-=-=-=-= Mostrar ordenamiento=-=-=-=-= \n"+
                                    "Qué lista desea mostrar? \n" +
                                    "\t\n" +
                                    "[1] Mostrar ordenamiento de burbuja simple\n" +
                                    "[2] Mostrar ordenamiento de burbuja mejorada\n" +
                                    "[3] Mostrar ordenamiento de burbuja optimizada\n");
                        Console.WriteLine("");
                        Console.WriteLine("[4] Volver al menú principal");
                        respuesta = Console.ReadKey().KeyChar;
                        Console.Clear();
                        switch (respuesta)
                        {
                            case '1':
                                Console.WriteLine("=-=-=-=-= Mostrando ordenamiento de burbuja simple =-=-=-=-=\n");
                                b.MetodoBurbujaSimple();
                                Console.WriteLine("");
                                Console.WriteLine("Presiona cualquier tecla para volver al menú");
                                Console.ReadKey();                                
                            break;
                            case '2':
                                Console.WriteLine("=-=-=-=-= Mostrando ordenamiento de burbuja mejorada =-=-=-=-=\n");
                                b.MetodoBurbujaMejorada();
                                Console.WriteLine("");
                                Console.WriteLine("Presiona cualquier tecla para volver al menú");
                                Console.ReadKey();                                 
                            break;
                            case '3':
                                Console.WriteLine("=-=-=-=-= Mostrando ordenamiento de burbuja optimizada =-=-=-=-=\n");
                                b.MetodoBurbujaOptimizada();
                                Console.WriteLine("");
                                Console.WriteLine("Presiona cualquier tecla para volver al menú");
                                Console.ReadKey();                                 
                            break;
                            case '4':
                                menu2 = 0;
                            break; 
                        }
                    }while(menu2 != 0);                        
                    break;                                        
                    case '5':
                    menu = 0;
                    break;
                }
            }while(menu != 0);
        }
    }
}

        
